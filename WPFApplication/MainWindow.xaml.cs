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
        List<Phone> listPhones;

        public MainWindow()
        {
            InitializeComponent();


            string[] phones = new string[] { "iPhone 6S", "Lumia 950", "Nexus 5X", "LG G4", "Xiaomi MI5", "HTC A9" };
            ListCSharpArray.ItemsSource = phones;

            listPhones = new List<Phone>
            {
                new Phone { Title="iPhone 6S", Company="Apple", Price=54990 },
                new Phone { Title = "Lumia 950", Company = "Microsoft", Price = 39990 },
                new Phone { Title = "Lumia 950", Company = "Microsoft", Price = 39990 }
            };

            CreateList();
            ListXaml.Items.Add("Lumia 550 add in code");
        }

        /*
         Коллекция объектов внутри элемента-списка доступна в виде свойства Items
            Add(object item): добавление элемента
            Clear(): полная очистка коллекции
            Insert(int index, object item): вставка элемента по определенному индексу в коллекции
            Remove(object item): удаление элемента
            RemoveAt(int index): удаление элемента по индексу
         */

        /*
            phonesList.Items[0] - первый элемент ListBox.
            phonesList.Items[2]="LG G 4" - установить третему элементу значение;
        */
        private void CreateList()
        {
            ListCSharpInCode.ItemsSource = listPhones;
            ListCSharpSelectedEvent.ItemsSource = listPhones;
        }

        /*
         При выделении элемента в списке генерируется событие SelectionChanged
            SelectedItem(SelectedItems) - получить выделенный элемент(ы) 
            SelectedItem(SelectedItems) - получить индекст выделенного елемента
            SelectedValue - получить значение выделенного элемента
         */
        private void ListCSharpSelectedEvent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone p = (Phone)ListCSharpSelectedEvent.SelectedItem;
            MessageBox.Show($"Title: {p.Title} Index: {ListCSharpSelectedEvent.SelectedIndex} {Environment.NewLine}Value: " +
                $"{ListCSharpSelectedEvent.SelectedValue}");
        }

        private void OnClick_AddToList(object sender, RoutedEventArgs e)
        {
            if (Title.Text != "" && Company.Text != "" && Price.Text != "")
            {
                ListCSharpAddRemoveElement.Items.Add(new Phone { Title = Title.Text, Company = Company.Text, Price = int.Parse(Price.Text)});
                Title.Clear();
                Company.Clear();
                Price.Clear();
            }
            else
                MessageBox.Show("Для добавления заполните все поля");
        }

        private void OnClick_RemoveFromList(object sender, RoutedEventArgs e)
        {
            if (ListCSharpAddRemoveElement.Items.Count > 1)
                ListCSharpAddRemoveElement.Items.RemoveAt(ListCSharpAddRemoveElement.Items.Count - 1);
            else
                MessageBox.Show("Больше нечего удалять");
        }
    }
}