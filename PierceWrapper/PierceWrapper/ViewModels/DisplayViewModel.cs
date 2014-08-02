using PierceWrapper.Models;

namespace PierceWrapper.ViewModels
{
    public class DisplayViewModel
    {
        private readonly Contact _contact;
        private readonly DisplayOption _displayOption;

        public DisplayViewModel(Contact contact, DisplayOption displayOption)
        {
            _contact = contact;
            _displayOption = displayOption;
        }

        public DisplayOption DisplayOption
        {
            get { return _displayOption; }
        }

        public string Display
        {
            get { return _contact.DisplayUsingOption(_displayOption); }
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            var that = obj as DisplayViewModel;
            if (that == null)
                return false;

            return this._displayOption == that._displayOption;
        }

        public override int GetHashCode()
        {
            return _displayOption.GetHashCode();
        }
    }
}
