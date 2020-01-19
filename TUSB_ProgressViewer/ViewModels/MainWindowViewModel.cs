using Microsoft.WindowsAPICodePack.Dialogs;
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
        /// ワールド選択コマンド
        /// </summary>
        public ReactiveCommand PickWorldCommand { get; } = new ReactiveCommand();

        /// <summary>
        /// リロードボタンコマンド
        /// </summary>
        public ReactiveCommand ReloadCommand { get; } = new ReactiveCommand();

        /// <summary>
        /// エラーダイアログクローズコマンド
        /// </summary>
        public ReactiveCommand ErrorDialogCloseCommand { get; } = new ReactiveCommand();

        /// <summary>
        /// ワールドフォルダ名
        /// </summary>
        public ReactiveProperty<string> FolderName => World.FolderName;

        /// <summary>
        /// 島攻略数
        /// </summary>
        public ReactiveProperty<int> CompletionCount => World.CompletionCount;

        /// <summary>
        /// 島攻略率
        /// </summary>
        public ReactiveProperty<double> CompletionRate => World.CompletionRate;

        /// <summary>
        /// スポナー破壊数
        /// </summary>
        public ReactiveProperty<int> BrokenCount => World.BrokenCount;

        /// <summary>
        /// スポナー破壊率
        /// </summary>
        public ReactiveProperty<double> BrokenRate => World.BrokenRate;

        public MainWindowViewModel()
        {
            TitlebarButtonCommand.Subscribe(x => Messenger.I.GetEvent<PubSubEvent<string>>().Publish(x));
            PickWorldCommand.Subscribe(() =>
            {
                var dialog = new CommonOpenFileDialog("ワールドフォルダを選択") { IsFolderPicker = true };
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok) World.Load(dialog.FileName);
            });
            ReloadCommand.Subscribe(() => World.Reload());
            ErrorDialogCloseCommand.Subscribe(() => World.IsError.Value = false);
        }
    }
}
