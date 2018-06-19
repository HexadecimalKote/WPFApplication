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
            double bText = 4.05;
            Button4.Content = bText;
            CreateButton7();
        }

        private void CreateButton7()
        {
            Button button7 = new Button();
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new TextBlock { Text = "Набор кнопок C#" });
            stackPanel.Children.Add(new Button { Content = "Blue", Height = 20, Background = new SolidColorBrush(Colors.Blue) });
            stackPanel.Children.Add(new Button { Content = "Yellow", Height = 20, Background = new SolidColorBrush(Colors.Yellow) });
            stackPanel.Children.Add(new Button { Content = "Magenta", Height = 20, Background = new SolidColorBrush(Colors.Magenta) });
            button7.Content = stackPanel;
            FirstStackPanel.Children.Add(button7);
        }
    }
}
