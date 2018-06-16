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
            CreateButton();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("XAML created button");
        }

        private void CreateButton()
        {
            Button myButton = new Button()
            {
                Width = 100,
                Height = 30,
                Content = "Кнопка из C#"
            };
            myButton.Click += OnMyButtonClick;
            LayoutGrid.Children.Add(myButton);
        }

        private void OnMyButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("C# created button");
        }
    }
}
