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

namespace SuperMain.MyForms
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            MyForms.AddProductWindow addProductWindow = new MyForms.AddProductWindow();
            addProductWindow.Show();
        }

        private void btnDelProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChanProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCheckListProduct_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
