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

namespace SuperMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.MyContext myContext = new DB.MyContext();

                if(myContext.users.Any(x => x.Login == tbLogin.Text && x.Password == pbPassword.Password))
                {
                    var user = myContext.users.SingleOrDefault(x => x.Login == tbLogin.Text && x.Password == pbPassword.Password);

                    switch (user.Role)
                    {
                        case "admin":
                            MessageBox.Show($"{user.UserName}, добро пожаловать!");
                            MyForms.AdminWindow adminWindow = new MyForms.AdminWindow();
                            adminWindow.Show();
                            Close();
                            break;
                        case "client":
                            MessageBox.Show($"{user.UserName}, добро пожаловать!");
                            MyForms.ClientWindow clientWindow = new MyForms.ClientWindow();
                            clientWindow.Show();
                            Close();
                            break;
                        case "Manager":
                            MessageBox.Show($"{user.UserName}, добро пожаловать!");
                            MyForms.ManagerWindow managerWindow = new MyForms.ManagerWindow(); 
                            managerWindow.Show();
                            Close();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void btnGoGuest_Click(object sender, RoutedEventArgs e)
        {
            MyForms.GuestWindow guestWindow = new MyForms.GuestWindow();
            guestWindow.Show();
            Close();
        }
    }
}
