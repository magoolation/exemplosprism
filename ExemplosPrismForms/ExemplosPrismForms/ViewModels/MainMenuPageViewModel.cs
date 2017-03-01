using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ExemplosPrismForms.ViewModels
{
    public class MainMenuPageViewModel : BindableBase, IMasterDetailPageOptions
    {
        public MainMenuPageViewModel(INavigationService navigationService)
        {
            NavigateCommand = new DelegateCommand<string>((uri) =>
            {
                navigationService.NavigateAsync(uri);
            });
        }

        public DelegateCommand<string> NavigateCommand { get; set; }

        public bool IsPresentedAfterNavigation
        {
            get
            {
                return Device.Idiom != TargetIdiom.Phone;
            }
        }
    }
}
