using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PierceWrapper.Models;

namespace PierceWrapper.ViewModels
{
    public abstract class InteractionViewModel
    {
        public abstract Interaction Interaction
        {
            get;
        }

        public string Date
        {
            get { return String.Format("{0:d}", Interaction.Date); }
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            var that = obj as InteractionViewModel;
            if (that == null)
                return false;

            return Object.Equals(this.Interaction, that.Interaction);
        }

        public override int GetHashCode()
        {
            return Interaction.GetHashCode();
        }

        public static InteractionViewModel For(Interaction interaction)
        {
            var emailMessage = interaction as EmailMessage;
            if (emailMessage != null)
                return new EmailMessageViewModel(emailMessage);

            var meeting = interaction as Meeting;
            if (meeting != null)
                return new MeetingViewModel(meeting);

            var phoneCall = interaction as PhoneCall;
            if (phoneCall != null)
                return new PhoneCallViewModel(phoneCall);

            throw new ArgumentException(String.Format("Unknown interaction type {0}.", interaction.GetType()));
        }
    }
}
