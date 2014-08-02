using PierceWrapper.Models;

namespace PierceWrapper.ViewModels
{
    public class MeetingViewModel : InteractionViewModel
    {
        private readonly Meeting _meeting;

        public MeetingViewModel(Meeting meeting)
        {
            _meeting = meeting;            
        }

        public override Interaction Interaction
        {
            get { return _meeting; }
        }

        public string Location
        {
            get { return _meeting.Location; }
        }
    }
}
