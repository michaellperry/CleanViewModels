﻿using Assisticant;
using PierceWrapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PierceWrapper.Views
{
    /// <summary>
    /// Interaction logic for ContactCardView.xaml
    /// </summary>
    public partial class ContactCardView : UserControl
    {
        public ContactCardView()
        {
            InitializeComponent();
        }

        void ContactCardView_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ForView.Unwrap<ContactCardViewModel>(e.NewValue, vm =>
                vm.Load());
        }
    }
}
