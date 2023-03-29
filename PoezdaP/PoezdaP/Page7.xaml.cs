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
using PoezdaP.RZDDataSetTableAdapters;

namespace PoezdaP
{
    /// <summary>
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        HistoryTableAdapter history = new HistoryTableAdapter();
        checkTableAdapter Checl = new checkTableAdapter();
        public Page7()
        {
            InitializeComponent();
            TableGrid.ItemsSource = Checl.GetData();
        }

        private void Korzina_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Content = new Page6();
        }

        private void BuyingTick_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Content = new Page5();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            object id = (TableGrid.SelectedItem as DataRowView).Row[0]; Convert.ToInt32(id);
            

            object name = (TableGrid.SelectedItem as DataRowView).Row[2]; Convert.ToString(name);
            
            
            object data = (TableGrid.SelectedItem as DataRowView).Row[3];

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string text = "        Чек\n" + $"     Кассовый чек №{id}\n" + $"{name}     -    от {Convert.ToString(data)}";


            File.AppendAllText($"{path}\\{id}.txt", text);

            MessageBox.Show("Чек на рабочем столе");

            

        }

        private void Chek_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Content = new Page7();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Content = new Page8();
        }
    }
}
