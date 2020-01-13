using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TUSB_ProgressViewer.ViewModels
{
    public class IslandPointerViewModel: BindableBase
    {
        private bool _isComplete;

        public bool IsComplete
        {
            get => _isComplete;
            set => SetProperty(ref _isComplete, value);
        }
    }
}
