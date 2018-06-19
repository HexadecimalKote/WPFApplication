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
            CreateCheckBox();
            CreateRadioButton();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((CheckBox)sender).Content.ToString() + " отмечен");
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((CheckBox)sender).Content.ToString() + " не отмечен");
        }

        private void CheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((CheckBox)sender).Content.ToString() + " в неопределенном состоянии");
        }

        private void CreateCheckBox()
        {
            CheckBox checkBox4 = new CheckBox { Content = "Флажок С#", Height = 30, IsChecked = false, Margin = new Thickness(20, 0, 0, 0), IsThreeState=true };
            checkBox4.Checked += CheckBox_Checked;
            checkBox4.Unchecked += CheckBox_Unchecked;
            checkBox4.Indeterminate += CheckBox_Indeterminate;
            stackPanel1.Children.Add(checkBox4);
        }

        private void CreateRadioButton()
        {
            RadioButton radioButton7 = new RadioButton { Content = "Console", Height = 20, Margin = new Thickness(20, 0, 0, 0), GroupName = "Technologies" };
            radioButton7.Checked        += RadioButton_Checked;
            radioButton7.Unchecked      += RadioButton_Unchecked;
            stackPanel2.Children.Add(radioButton7);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((RadioButton)sender).Content.ToString() + " отмечен");
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((RadioButton)sender).Content.ToString() + " не отмечен");
        }
    }
}
