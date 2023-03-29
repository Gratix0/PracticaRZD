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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProfileTableAdapter User = new ProfileTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            //TestGrid.ItemsSource = Profile.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var allLogin = User.GetData().Rows;
            bool flag = false;

            if (LoginBox.Text.Length < 3)
            {
                LoginBox.ToolTip = "Ошибка!";
                LoginBox.Background = Brushes.DarkRed;
            } 
            else if (PasswordBox.Password.Length < 3)
            {
                PasswordBox.ToolTip = "Ошибка!";
                PasswordBox.Background = Brushes.DarkRed;
            }
            try
            {
                for (int i = 0; i < allLogin.Count; i++)
                {
                    if (allLogin[i][1].ToString() == LoginBox.Text &&
                        allLogin[i][2].ToString() == PasswordBox.Password)
                    {
                        int role = (int)allLogin[i][3];

                        switch (role)
                        {
                            case 1:
                                Window1 rolen = new Window1();
                                MainWindow main = new MainWindow();
                                main.Close();
                                rolen.Show();
                                flag = true;
                                break;

                            case 2:
                                Window2 win2 = new Window2();
                                MainWindow mainn = new MainWindow();
                                mainn.Close();
                                win2.Show();
                                flag = true;
                                break;
                        }
                        
                        
                        break;
                    }

                }
                if (flag == false)
                {
                    MessageBox.Show("Ошибка");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
            
        }
    }
}