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
using TUSB_ProgressViewer.Util;

namespace TUSB_ProgressViewer.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public ReactiveCommand<string> TitlebarButtonCommand { get; } = new ReactiveCommand<string>();

        public ReactiveProperty<List<Island>> Islands { get; } = new ReactiveProperty<List<Island>>(new List<Island>());
        public ReactiveProperty<int> CompleteCount { get; } = new ReactiveProperty<int>();

        [Obsolete]
        public MainWindowViewModel()
        {
            TitlebarButtonCommand.Subscribe(x => Messenger.I.GetEvent<PubSubEvent<string>>().Publish(x));

            var world = AnvilWorld.Load("E:\\Profiles\\1.10.2\\saves\\The Unusual Skyblock v12.0.9");
            foreach (IslandType type in Enum.GetValues(typeof(IslandType)))
            {
                Islands.Value.Add(new Island(type, world));
            }
            CompleteCount.Value = Islands.Value.Where(x => x.IsComplete).Count();
        }
    }
}
