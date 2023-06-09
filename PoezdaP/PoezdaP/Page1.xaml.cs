﻿using System;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        ProfileTableAdapter Login = new ProfileTableAdapter();
        DolhnostTableAdapter Dolhnost = new DolhnostTableAdapter();
        public Page1()
        {
            InitializeComponent();
            TableGrid.ItemsSource = Login.GetData();
        }

        private void DolhnostBtn_Click(object sender, RoutedEventArgs e)
        {
           
            MyFrame.Content = new Page2();

        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            object id = (TableGrid.SelectedItem as DataRowView).Row[0];
            Login.UpdateQuery(OneTbx.Text, TwoTbx.Text, Convert.ToInt32(ThreeTbx.Text), Convert.ToInt32(id));

            TableGrid.ItemsSource = Login.GetData();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Login.InsertQuery(Convert.ToString(OneTbx.Text), Convert.ToString(TwoTbx.Text), Convert.ToInt32(ThreeTbx.Text));
                TableGrid.ItemsSource = Login.GetData();
            }
            catch
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            object id = (TableGrid.SelectedItem as DataRowView).Row[0];
            Login.DeleteQuery(Convert.ToInt32(id));
            TableGrid.ItemsSource = Login.GetData();

        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void TicketBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page3();
        }

        private void AllProfile_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page4();

        }
    }
}
