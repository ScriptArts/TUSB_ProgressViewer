using OrangeNBT.World.Anvil;
using Prism.Events;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUSB_ProgressViewer.Models;
using TUSB_ProgressViewer.Util;

namespace TUSB_ProgressViewer.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        /// <summary>
        /// タイトルバーのシステムボタンのコマンド
        /// </summary>
        public ReactiveCommand<string> TitlebarButtonCommand { get; } = new ReactiveCommand<string>();

        /// <summary>
        /// リロードボタンコマンド
        /// </summary>
        public ReactiveCommand ReloadCommand { get; } = new ReactiveCommand();

        /// <summary>
        /// 島攻略数
        /// </summary>
        public ReactiveProperty<int> CompleteCount => World.CompleteCount;

        public MainWindowViewModel()
        {
            TitlebarButtonCommand.Subscribe(x => Messenger.I.GetEvent<PubSubEvent<string>>().Publish(x));
            ReloadCommand.Subscribe(() => World.Load("E:\\Profiles\\1.10.2\\saves\\The Unusual Skyblock v12.0.9"));

            World.Load("E:\\Profiles\\1.10.2\\saves\\The Unusual Skyblock v12.0.8");
        }
    }
}
