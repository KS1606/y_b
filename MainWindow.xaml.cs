using System;
using System.Collections.Generic;
using System.IO.Packaging;
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

namespace budget_accounting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<string> list = new List<string>();
        private string item = "";
        public MainWindow()
        {
            InitializeComponent();
            Tips.ItemsSource = list;
        }

        private void Nov_tip_Click(object sender, RoutedEventArgs e)
        {
            DobavTip wind = new DobavTip();
            wind.Show();
        }

        public void  Okno(string tip)
        {
            item = tip;
            MessageBox.Show(item);
            list.Add(item);
            Zapolnenie();
        }

        private void Zapolnenie()
        {
            
        }
    }
}
