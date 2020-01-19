using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace TUSB_ProgressViewer.Behaviors
{
    class ScrollViewBehavior : Behavior<ScrollViewer>
    {
        protected override void OnAttached()
        {
            base.OnAttached();

            // マウスホイールによる操作を横スクロールに変換
            AssociatedObject.PreviewMouseWheel += (s, e) => AssociatedObject.ScrollToHorizontalOffset(AssociatedObject.HorizontalOffset - e.Delta);
        }
    }
}
