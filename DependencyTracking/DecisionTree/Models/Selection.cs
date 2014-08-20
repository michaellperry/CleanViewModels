﻿using Assisticant.Fields;

namespace DecisionTree.Models
{
    public class Selection
    {
        private Observable<IPath> _selectedPath = new Observable<IPath>();

        public IPath SelectedPath
        {
            get { return _selectedPath.Value; }
            set { _selectedPath.Value = value; }
        }
    }
}