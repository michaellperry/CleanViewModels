using Assisticant.Fields;
using System;
using System.Threading.Tasks;

namespace AssisticantMobile.ViewModels
{
    public class AsynchronousViewModel
    {
        private Observable<bool> _busy = new Observable<bool>(default(bool));
        private Observable<Exception> _lastException = new Observable<Exception>(default(Exception));

        public bool HasError
        {
            get { return _lastException.Value != null; }
        }

        public string Error
        {
            get
            {
                return _lastException.Value == null
                    ? null
                    : _lastException.Value.Message;
            }
        }

        public bool Busy
        {
            get { return _busy; }
        }

        protected async void Perform(Func<Task> work)
        {
            try
            {
                _lastException.Value = null;
                _busy.Value = true;

                await work();
            }
            catch (Exception ex)
            {
                _lastException.Value = ex;
            }
            finally
            {
                _busy.Value = false;
            }
        }
    }
}
