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

            listPhones = new List<Phone>
            {
                new Phone { Title="iPhone 6S", Company="Apple", Price=54990 },
                new Phone {Title="Lumia 950", Company="Microsoft", Price=39990 },
                new Phone {Title="Nexus 5X", Company="Google", Price=29990 }
            };

            /*
           RowBackground и AlternatingRowBackground Устанавливают фон строки. 
             Если установлены оба свойства, цветовой фон чередуется: 
             RowBackground - для нечетных строк и AlternatingRowBackground - для четных

           ColumnHeaderHeight - Устанавливает высоту строки названий столбцов.

           ColumnWidth - Устанавливает ширину столбцов.

           RowHeight - Устанавливает высоту строк.

           GridLinesVisibility Устанавливает видимость линий, разделяющих столбцы и строки. 
           Имеет четыре значения -
                All - видны все линии, 
                Horizontal - видны только горизонтальные линии, 
                Vertical - видны только вертикальные линии, 
                None - линии отсутствуют

           HeadersVisibility - Задает видимость заголовков

           HorizontalGridLinesBrush и VerticalGridLinesBrush
           Задает цвет горизонтальных и вертикальных линий соответственно
             */
            phonesGrid_1.ItemsSource = listPhones;
            phonesGrid_1.ColumnHeaderHeight = 25;
        }
    }
}