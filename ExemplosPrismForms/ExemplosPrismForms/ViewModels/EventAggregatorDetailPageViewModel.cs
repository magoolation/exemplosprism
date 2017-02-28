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
    public class EventAggregatorDetailPageViewModel : BindableBase
    {
        private IEventAggregator _eventAggregator;

        private Color _boxColor = Color.White;
        public Color BoxColor
        {
            get { return _boxColor; }
            set { SetProperty(ref _boxColor, value); }
        }

        public EventAggregatorDetailPageViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<ChangeColorEvent>().Subscribe((payload) =>
            {
                BoxColor = payload;
            });
        }
    }
}
