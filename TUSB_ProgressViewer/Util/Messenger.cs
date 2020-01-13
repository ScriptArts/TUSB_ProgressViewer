using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUSB_ProgressViewer.Util
{
    public class Messenger: EventAggregator
    {
        public static Messenger I { get; } = new Messenger();
    }
}
