using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            MessageBox.Show(tvItem.Header.ToString() + " раскрыт");
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            MessageBox.Show("Выбран узел: " + tvItem.Header.ToString());
        }
    }
}