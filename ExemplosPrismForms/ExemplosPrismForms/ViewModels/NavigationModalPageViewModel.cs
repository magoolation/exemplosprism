using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPrismForms.ViewModels
{
    public class NavigationModalPageViewModel : BindableBase, IConfirmNavigationAsync
    {
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;

        public NavigationModalPageViewModel(INavigationService navigationService, 
            IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;

            ContinueCommand = new DelegateCommand(() =>
            {
                _navigationService.GoBackAsync();
            });
        }

        public DelegateCommand ContinueCommand { get; set; }

        private bool _lieConcordo = false;
        public bool LieConcordo
        {
            get { return _lieConcordo; }
            set { SetProperty(ref _lieConcordo, value); }
        }
                
        public async Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            if(!_lieConcordo)
            {
                await _pageDialogService.DisplayAlertAsync("Atenção", "Por favor aceite os termos antes de continuar!","Ok");
            }
            return _lieConcordo;
        }
    }
}
