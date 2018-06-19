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
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка нажата обработчик добавлен в C#");
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка нажата обработчик добавлен в XAML");
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Действие выполнено");
        }

        private void EscButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // закрытие окна
        }

        private void AddTextInTextBox(object sender, RoutedEventArgs e)
        {
            RepeatedText.Text += "World";
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            toggleTextBlock.Text = "Button is Checked";
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            toggleTextBlock.Text = "Button is unchecked.";
        }

        private void HandleIntermediate(object sender, RoutedEventArgs e)
        {
            toggleTextBlock.Text = "Button is Intermediate.";
        }
    }
}
