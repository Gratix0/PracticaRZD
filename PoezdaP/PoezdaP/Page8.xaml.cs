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
using PoezdaP.RZDDataSetTableAdapters;

namespace PoezdaP
{
    /// <summary>
    /// Логика взаимодействия для Page8.xaml
    /// </summary>
    public partial class Page8 : Page
    {
        HistoryTableAdapter history = new HistoryTableAdapter();
        public Page8()
        {
            InitializeComponent();
            TableGrid.ItemsSource = history.GetData();
        }

        private void BuyingTick_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Content = new Page5();

        }

        private void Korzina_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Content = new Page6();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Content = new Page8();

        }

        private void Chek_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Content = new Page7();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Content = new Page7();
        }
    }
}
