using PierceWrapper.Models;

namespace PierceWrapper.ViewModels
{
    public class EmailMessageViewModel : InteractionViewModel
    {
        private readonly EmailMessage _emailMessage;

        public EmailMessageViewModel(EmailMessage emailMessage)
        {
            _emailMessage = emailMessage;
        }

        public override Interaction Interaction
        {
            get { return _emailMessage; }
        }

        public bool Sent
        {
            get { return _emailMessage.Sent; }
        }
    }
}
