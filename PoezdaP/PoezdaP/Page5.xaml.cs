using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        ticketTableAdapter Ticket = new ticketTableAdapter();
        checkTableAdapter Check = new checkTableAdapter();
        basketTableAdapter basket = new basketTableAdapter();
        public Page5()
        {
            

            InitializeComponent();
            TableGrid.ItemsSource = Ticket.GetData();
        }

        private void BuyingTick_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Korzina_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Content = new Page6();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            object id = (TableGrid.SelectedItem as DataRowView).Row[0];
            object name = (TableGrid.SelectedItem as DataRowView).Row[1];
            object id_profile = 2;
            basket.InsertQuery(Convert.ToInt32(id_profile), Convert.ToInt32(id));
        }

        private void Chek_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
