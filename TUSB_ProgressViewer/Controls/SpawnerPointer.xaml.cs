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
    /// SpawnerPointer.xaml の相互作用ロジック
    /// </summary>
    public partial class SpawnerPointer : UserControl
    {
        public static DependencyProperty IsBrokenProperty = DependencyProperty.Register(nameof(IsBroken), typeof(bool), typeof(SpawnerPointer));
        public static DependencyProperty CenterProperty = DependencyProperty.Register(nameof(Center), typeof(Point), typeof(SpawnerPointer));

        /// <summary>
        /// スポナー破壊フラグ
        /// </summary>
        public bool IsBroken
        {
            get => (bool)GetValue(IsBrokenProperty);
            set => SetValue(IsBrokenProperty, value);
        }

        /// <summary>
        /// 地図上の座標
        /// </summary>
        public Point Center
        {
            get => (Point)GetValue(CenterProperty);
            set => SetValue(CenterProperty, value);
        }

        public SpawnerPointer()
        {
            InitializeComponent();
        }
    }
}
