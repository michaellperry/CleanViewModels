using Assisticant;
using AssisticantMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssisticantMobile.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private Topic _topic = new Topic
        {
            Name = "Information Theory"
        };

        public object Topic
        {
            get
            {
                return ViewModel(() => new TopicViewModel(_topic));
            }
        }
    }
}
