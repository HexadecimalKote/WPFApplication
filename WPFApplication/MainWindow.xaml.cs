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
            CreateToolTipForButton();
        }

        private void CreateToolTipForButton()
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = "Header", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = "Some Text" });
            toolTip.Content = toolTipPanel;
            buttonToolTip.ToolTip = toolTip;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            popup.IsOpen = true;
        }
    }
}
