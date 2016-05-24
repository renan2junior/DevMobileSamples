﻿using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;
using MVVMWithPrism.Views;

namespace MVVMWithPrism
{
    public sealed partial class App : MvvmAppBase
    {
        private readonly IUnityContainer _container = new UnityContainer();

        public App()
        {
            this.InitializeComponent();
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            _container.RegisterInstance(SessionStateService);
            _container.RegisterInstance(NavigationService);
            ViewModelLocationProvider.SetDefaultViewModelFactory
                ((viewModelType) => _container.Resolve(viewModelType));
            NavigationService.Navigate(Experiences.Main.ToString(), null);
            return Task.FromResult<object>(null);
        }
    }
}