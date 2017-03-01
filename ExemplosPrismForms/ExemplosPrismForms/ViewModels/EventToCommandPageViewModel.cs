using ExemplosPrismForms.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ExemplosPrismForms.ViewModels
{
    public class EventToCommandPageViewModel : BindableBase
    {
        private readonly IPageDialogService _pageDialogService;

        public EventToCommandPageViewModel(IPageDialogService pageDialogService)
        {
            _pageDialogService = pageDialogService;

            ItemTappedCommand = new DelegateCommand<Pessoa>((pessoa) =>
            {
                _pageDialogService.DisplayAlertAsync("Atenção", string.Format("Obrigado pelo interesse em {0}!", pessoa.Nome), "Ok");
            });

            _pessoas = new ObservableCollection<Pessoa>();
            _pessoas.Add(new Pessoa() { Nome = "Alexandre Santos Costa", Bio = "Microsoft MVP" });
            _pessoas.Add(new Pessoa() { Nome = "Angelo Belchior", Bio = "Microsoft MVP" });
            _pessoas.Add(new Pessoa() { Nome = "Victor Cavalcante", Bio = "Microsoft MVP" });
        }

        public ObservableCollection<Pessoa> _pessoas;
        public ObservableCollection<Pessoa> Pessoas
        {
            get { return _pessoas; }
            set { SetProperty(ref _pessoas, value); }
        }

        public DelegateCommand<Pessoa> ItemTappedCommand { get; set; }
    }
}
