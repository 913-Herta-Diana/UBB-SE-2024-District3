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
using System.Windows.Shapes;

namespace District_3_App.ExtraInfo
{
    /// <summary>
    /// Interaction logic for MyMainWindow.xaml
    /// </summary>
    public partial class MyMainWindow : Window
    {
        public MyMainWindow()
        {
            InitializeComponent();
        }

        private void ExtraInfoButton_Click(object sender, RoutedEventArgs e)
        {
            ExtraInfoControl.Content = new ExtraInfo();
        }
    }
}