using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemplosPrismForms.ViewModels
{
    public class NavigationServicePageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public NavigationServicePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateCommand = new DelegateCommand<string>((uri) =>
            {
                _navigationService.NavigateAsync(uri, useModalNavigation: uri.Contains("Modal"));
            });
        }

        public DelegateCommand<string> NavigateCommand { get; set; }
    }
}