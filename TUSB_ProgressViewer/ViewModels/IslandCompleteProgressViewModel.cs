using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUSB_ProgressViewer.Models;
using TUSB_ProgressViewer.Util;

namespace TUSB_ProgressViewer.ViewModels
{
    public class IslandCompleteProgressViewModel
    {
        /// <summary>
        /// 島リスト
        /// </summary>
        public ReactiveCollection<Island> Islands => World.Islands;
    }
}
