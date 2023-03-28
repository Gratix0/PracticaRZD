﻿using PoezdaP.RZDDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        ticketTableAdapter Ticket = new ticketTableAdapter();
        checkTableAdapter Check = new checkTableAdapter();
        basketTableAdapter basket = new basketTableAdapter();
        public Page6()
        {


            InitializeComponent();
            TableGrid.ItemsSource = basket.GetData();
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
            object id = (TableGrid.SelectedItem as DataRowView).Row[0]; Convert.ToInt32(id);
            object name = (TableGrid.SelectedItem as DataRowView).Row[1]; Convert.ToString(name);
            object price = (TableGrid.SelectedItem as DataRowView).Row[2]; Convert.ToInt32(price);
            object cvo = (TableGrid.SelectedItem as DataRowView).Row[3]; Convert.ToInt32(cvo);
            int total_price = (Convert.ToInt32(price) * Convert.ToInt32(cvo));

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string text = "        Чек\n" + $"     Кассовый чек №{id}\n" + $"{name}     -    {price} - {cvo}\n" + $"Итого к оплате: {total_price}";

            File.AppendAllText($"{path}\\{id}.txt", text);
        }

        private void Chek_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

