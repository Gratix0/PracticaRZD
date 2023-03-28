﻿using PoezdaP.RZDDataSetTableAdapters;
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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        ProfileTableAdapter Login = new ProfileTableAdapter();
        DolhnostTableAdapter Dolhnost = new DolhnostTableAdapter();
        UserTableAdapter User = new UserTableAdapter();
        public Page4()
        {
            InitializeComponent();
            TableGrid.ItemsSource = User.GetData();
        }


        private void DolhnostBtn_Click(object sender, RoutedEventArgs e)
        {
            TableGrid.ItemsSource = Dolhnost.GetData();
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
           /* object id = (TableGrid.SelectedItem as DataRowView).Row[0];
            Dolhnost.UpdateQuery(NameDolhTB.Text, Convert.ToInt32(OcladTB.Text), Convert.ToInt32(id));
            TableGrid.ItemsSource = Dolhnost.GetData();*/
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                /*Convert.ToInt32(OcladTB.Text);

                Dolhnost.InsertQuery(Convert.ToString(NameDolhTB.Text), Convert.ToInt32(OcladTB.Text));
                TableGrid.ItemsSource = Dolhnost.GetData();*/
            }
            catch
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            object id = (TableGrid.SelectedItem as DataRowView).Row[0];
            Dolhnost.DeleteQuery(Convert.ToInt32(id));
            TableGrid.ItemsSource = Dolhnost.GetData();

        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame4.Content = new Page1();



        }

        private void TicketBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame4.Content = new Page3();
        }

        private void TicketBtn_Click_1(object sender, RoutedEventArgs e)
        {
            MyFrame4.Content = new Page3();
        }
    }
}
