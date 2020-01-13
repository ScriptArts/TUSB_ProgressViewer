using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;
using TUSB_ProgressViewer.Util;

namespace TUSB_ProgressViewer.Behaviors
{
    public class MainWindowBehavior : Behavior<Window>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            Messenger.I.GetEvent<PubSubEvent<string>>().Subscribe(x =>
            {
                if      (x == "Close")    AssociatedObject.Close();
                else if (x == "Maximize") AssociatedObject.WindowState = AssociatedObject.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
                else if (x == "Minimize") AssociatedObject.WindowState = WindowState.Minimized;
            });
        }
    }
}
