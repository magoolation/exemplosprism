using ExemplosPrismForms.Events;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ExemplosPrismForms.ViewModels
{
    public class EventAggregatorPageViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;

        public EventAggregatorPageViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            ChangeColorCommand = new DelegateCommand<string>((colorCode) =>
            {
                Color color = Color.FromHex(colorCode);

                _eventAggregator.GetEvent<ChangeColorEvent>().Publish(color);
            });
        }

        public DelegateCommand<string> ChangeColorCommand { get; set; }
    }
}
