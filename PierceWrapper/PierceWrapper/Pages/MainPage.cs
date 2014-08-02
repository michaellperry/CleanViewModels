﻿using Assisticant;
using PierceWrapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PierceWrapper.Services;
using Assisticant.Fields;

namespace PierceWrapper.Pages
{
    public class MainPage
    {
        private ContactRepository _repository = null;
        private DialogManager _dialogManager = null;
        private Observable<int> _contactId = new Observable<int>(42);

        public MainPage(ContactRepository repository, DialogManager dialogManager)
        {
            _repository = repository;
            _dialogManager = dialogManager;
        }
    }
}
