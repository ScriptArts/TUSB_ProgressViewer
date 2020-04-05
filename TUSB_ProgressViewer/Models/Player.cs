using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUSB_ProgressViewer.Models
{
    public class Player : BindableBase
    {
        /// <summary>
        /// ユーザー名
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 剣士レベル
        /// </summary>
        public int KnightLevel { get; set; }

        /// <summary>
        /// 忍者レベル
        /// </summary>
        public int NinjaLevel { get; set; }

        /// <summary>
        /// 狩人レベル
        /// </summary>
        public int ArcherLevel { get; set; }

        /// <summary>
        /// 白魔道士レベル
        /// </summary>
        public int WhiteMageLevel { get; set; }

        /// <summary>
        /// 黒魔道士レベル
        /// </summary>
        public int BlackMageLevel { get; set; }

        /// <summary>
        /// 召喚士レベル
        /// </summary>
        public int SummonerLevel { get; set; }

        /// <summary>
        /// 選択中フラグ
        /// </summary>
        public bool IsSelected { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
