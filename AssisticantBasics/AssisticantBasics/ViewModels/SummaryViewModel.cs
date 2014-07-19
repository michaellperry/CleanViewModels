using AssisticantBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssisticantBasics.ViewModels
{
    public class SummaryViewModel
    {
        private readonly Document _document;

        public SummaryViewModel(Document document)
        {
            _document = document;
        }

        public int Total
        {
            get { return _document.Total; }
        }
    }
}
