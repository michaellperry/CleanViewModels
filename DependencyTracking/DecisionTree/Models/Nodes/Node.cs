using Assisticant.Fields;
using DecisionTree.Models.Paths;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace DecisionTree.Models.Nodes
{
    public abstract class Node
    {
        private Observable<string> _label = new Observable<string>();

        public string Label
        {
            get { return _label; }
            set { _label.Value = value; }
        }

        public float ExpectedValue
        {
            get { return ComputeExpectedValue(); }
        }

        public abstract IEnumerable<Path> Paths { get; }
        protected abstract float ComputeExpectedValue();

        public event EventHandler ExpectedValueComputed;

        public void RaiseExpectedValueComputed()
        {
            lock (_computedNodes)
            {
                _computedNodes.Enqueue(this);
            }
            _computedNodesReady.Set();
        }

        private static Queue<Node> _computedNodes = new Queue<Node>();
        private static AutoResetEvent _computedNodesReady = new AutoResetEvent(false);
        private static Dispatcher _mainDispatcher;
        
        static Node()
        {
            if (!DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                _mainDispatcher = Dispatcher.CurrentDispatcher;

                Thread eventsThread = new Thread(RaiseEvents);
                eventsThread.Name = "Events Thread";
                eventsThread.IsBackground = true;
                eventsThread.Start();
            }
        }

        private static void RaiseEvents()
        {
            while (true)
            {
                Node nextNode = null;
                lock (_computedNodes)
                {
                    if (_computedNodes.Any())
                        nextNode = _computedNodes.Dequeue();
                }

                if (nextNode != null)
                {
                    if (_mainDispatcher != null)
                    {
                        _mainDispatcher.BeginInvoke(new Action(delegate
                        {
                            if (nextNode.ExpectedValueComputed != null)
                                nextNode.ExpectedValueComputed(nextNode, new EventArgs());
                        }), DispatcherPriority.Background);
                    }
                    Thread.Sleep(100);
                }
                else
                {
                    _computedNodesReady.WaitOne();
                }
            }
        }
    }
}
