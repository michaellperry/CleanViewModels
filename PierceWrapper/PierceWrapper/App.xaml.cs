using Autofac;
using PierceWrapper.Pages;
using PierceWrapper.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PierceWrapper
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IContainer _container;

        protected override void OnStartup(StartupEventArgs e)
        {
            BuildContainer();

            base.OnStartup(e);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }

        private void BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ContactRepository>();
            builder.RegisterType<DialogManager>();
            builder.RegisterType<MainPage>();

            _container = builder.Build();
        }
    }
}
