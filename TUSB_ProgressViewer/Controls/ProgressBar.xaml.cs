using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TUSB_ProgressViewer.Controls
{
    /// <summary>
    /// ProgressBar.xaml の相互作用ロジック
    /// </summary>
    public partial class ProgressBar : UserControl
    {
        public static DependencyProperty ValueProperty = DependencyProperty.Register(nameof(Value), typeof(double), typeof(ProgressBar));

        /// <summary>
        /// 値
        /// </summary>
        public double Value
        {
            get => (double)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public ProgressBar()
        {
            InitializeComponent();
        }
    }
}
