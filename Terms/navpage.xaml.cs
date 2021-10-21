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

namespace Terms
{
    /// <summary>
    /// Логика взаимодействия для navpage.xaml
    /// </summary>
    public partial class navpage : Page
    {
        public navpage()
        {
            InitializeComponent();
        }
    
        private void Geopolitic_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Geopolitic());
        }
        private void BtnBack_Click3(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
        private void BtnBack_Click4(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}
