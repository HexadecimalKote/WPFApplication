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
            CreateTab();
        }

        private void CreateTab()
        {
            ListBox notesList = new ListBox();
            notesList.Items.Add("Macbook Pro");
            notesList.Items.Add("HP Pavilion 5478");
            notesList.Items.Add("Acer LK-08");

            otherProducts.Items.Add(
                new TabItem
                {
                    Header = new TextBlock { Text = "Ноутбуки in C# code" },
                    Content = notesList
                }
            );
        }
    }
}