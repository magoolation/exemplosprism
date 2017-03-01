using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemplosPrismForms.ViewModels
{
    public class DelegateCommandPageViewModel : BindableBase
    {
        public DelegateCommandPageViewModel(INavigationService navigationService)
        {
            LoginCommand = new DelegateCommand(() =>
            {
                navigationService.NavigateAsync("NavigationPage/MainPage");
            }, () => !string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(_password))
            .ObservesProperty(() => UserName)
            .ObservesProperty(() => Password);
        }

        public DelegateCommand LoginCommand { get; set; }
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

    }
}
