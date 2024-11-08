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

namespace DZ1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int number = -1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            ListView1.Items.Add((number = number + 1).ToString());
        }

        private void Button_Del(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListView1.SelectedItems.Cast<string>().ToList();
            foreach (var item in selectedItems)
            {
                ListView1.Items.Remove(item);
            }
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            ListView1.Items.Clear();
            number = -1;
        }
    }
}