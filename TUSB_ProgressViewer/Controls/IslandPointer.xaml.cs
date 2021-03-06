﻿using System;
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
    /// IslandPointer.xaml の相互作用ロジック
    /// </summary>
    public partial class IslandPointer : UserControl
    {
        public static DependencyProperty IslandNameProperty = DependencyProperty.Register(nameof(IslandName), typeof(string), typeof(IslandPointer));
        public static DependencyProperty IsCompleteProperty = DependencyProperty.Register(nameof(IsComplete), typeof(bool), typeof(IslandPointer));
        public static DependencyProperty IsSelectedProperty = DependencyProperty.Register(nameof(IsSelected), typeof(bool), typeof(IslandPointer));
        public static DependencyProperty CenterProperty = DependencyProperty.Register(nameof(Center), typeof(Point), typeof(IslandPointer));

        /// <summary>
        /// 島名
        /// </summary>
        public string IslandName
        {
            get => (string)GetValue(IslandNameProperty);
            set => SetValue(IslandNameProperty, value);
        }

        /// <summary>
        /// 攻略フラグ
        /// </summary>
        public bool IsComplete
        {
            get => (bool)GetValue(IsCompleteProperty);
            set => SetValue(IsCompleteProperty, value);
        }

        /// <summary>
        /// 選択フラグ
        /// </summary>
        public bool IsSelected
        {
            get => (bool)GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }

        /// <summary>
        /// 地図上の座標
        /// </summary>
        public Point Center
        {
            get => (Point)GetValue(CenterProperty);
            set => SetValue(CenterProperty, value);
        }

        public IslandPointer()
        {
            InitializeComponent();
        }
    }
}
