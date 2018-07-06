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
        List<Phone> phoneList;

        public MainWindow()
        {
            InitializeComponent();

            phoneList = new List<Phone>
            {
                new Phone { Title="iPhone 6S", Company="Apple",     Price=54990 },
                new Phone { Title="Lumia 950", Company="Microsoft", Price=39990 },
                new Phone { Title="Nexus 5X", Company="Google",     Price=29990 }
            };

            phonesList.ItemsSource = phoneList;
        }
    }
}