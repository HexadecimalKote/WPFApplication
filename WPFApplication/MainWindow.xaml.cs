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
            CreateExpander();
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            ((Expander)sender).Content = new Button() { Width = 80, Height = 30, Content = "Привет", Margin = new Thickness(10) };
        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Экспандер свернут");
        }

        private void CreateExpander()
        {
            StackPanel expanderPanel = new StackPanel();
            expanderPanel.Children.Add(new CheckBox { Content = "WinForms" });
            expanderPanel.Children.Add(new CheckBox { Content = "WPF" });
            expanderPanel.Children.Add(new CheckBox { Content = "ASP.NET" });

            Expander expander = new Expander
            {
                Header = "Expander create in C#",
                Content = expanderPanel,
                Margin = new Thickness(10, 0, 0, 0)
            };

            FourStackPanel.Children.Add(expander);
        }
    }
}
