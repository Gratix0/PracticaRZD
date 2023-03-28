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
using System.Windows.Shapes;
using PoezdaP.RZDDataSetTableAdapters;

namespace PoezdaP
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ProfileTableAdapter Login = new ProfileTableAdapter();
        DolhnostTableAdapter Dolhnost = new DolhnostTableAdapter();
        public Window1()
        {
            InitializeComponent();
            Tablica.ItemsSource = Login.GetData();
        }

        private void DolhnostBtn_Click(object sender, RoutedEventArgs e)
        {
            Tablica.ItemsSource = Dolhnost.GetData();
        }
    }
}
