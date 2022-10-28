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
    /// Логика взаимодействия для ChangeProductWindow.xaml
    /// </summary>
    public partial class ChangeProductWindow : Window
    {
        public ChangeProductWindow()
        {
            InitializeComponent();
        }

        public void btnOpenChange_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
