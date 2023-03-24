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

namespace budget_accounting
{
    /// <summary>
    /// Логика взаимодействия для DobavTip.xaml
    /// </summary>
    public partial class DobavTip : Window
    {
        public string tip = "";
        public DobavTip()
        {
            InitializeComponent();
        }

        private void DobavZap_Click(object sender, RoutedEventArgs e)
        {
            tip = Name.Text;
            MessageBox.Show(tip);
            MainWindow wind = new MainWindow();
            wind.Okno(tip);
            Close();
        }
    }
}
