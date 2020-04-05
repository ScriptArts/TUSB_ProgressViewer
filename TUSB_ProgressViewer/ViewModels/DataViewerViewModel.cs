using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUSB_ProgressViewer.Models;

namespace TUSB_ProgressViewer.ViewModels
{
    public class DataViewerViewModel : BindableBase
    {
        /// <summary>
        /// 選択中プレイヤー
        /// </summary>
        public ReactiveProperty<Player> SelectedPlayer { get; set; } = new ReactiveProperty<Player>();
    }
}
