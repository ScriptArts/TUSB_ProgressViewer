using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TUSB_ProgressViewer.Controls;
using TUSB_ProgressViewer.Models;

namespace TUSB_ProgressViewer.ViewModels
{
    public class EndSpawnerProgressViewModel
    {
        /// <summary>
        /// スポナーリスト
        /// </summary>
        public ReactiveCollection<SpawnerPointer> Spawners => World.Spawners;
    }
}
