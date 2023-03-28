using PoezdaP.RZDDataSetTableAdapters;
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

namespace PoezdaP
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        ProfileTableAdapter Login = new ProfileTableAdapter();
        DolhnostTableAdapter Dolhnost = new DolhnostTableAdapter();
        ticketTableAdapter Ticket = new ticketTableAdapter();
        public Page3()
        {
            InitializeComponent();
            TableGrid.ItemsSource = Ticket.GetData();
        }


        private void DolhnostBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame3.Content = new Page2();
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (TableGrid.SelectedItem as DataRowView).Row[0];
                Ticket.UpdateQuery(NameDolhTB.Text, OcladTB.Text, OpicanieTB.Text, Convert.ToInt32(CostTB.Text), Convert.ToInt32(id));
                TableGrid.ItemsSource = Ticket.GetData();
            }
            catch
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Convert.ToInt32(CostTB.Text);

                Ticket.InsertQuery(Convert.ToString(NameDolhTB.Text), Convert.ToString(OcladTB.Text), Convert.ToString(OpicanieTB.Text), Convert.ToInt32(CostTB.Text));
                TableGrid.ItemsSource = Ticket.GetData();
            }
            catch
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            object id = (TableGrid.SelectedItem as DataRowView).Row[0];
            Ticket.DeleteQuery(Convert.ToInt32(id));
            TableGrid.ItemsSource = Ticket.GetData();

        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame3.Content = new Page1();



        }
    }
}
