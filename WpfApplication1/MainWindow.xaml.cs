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
using System.IO;
using System.Collections;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Komanda k;
            List<Komanda> mass = new List<Komanda>();
            while (true)
            {
                string[] str;
                string stroka = Console.ReadLine();
                if (stroka == null) break;
                str = stroka    .Split(',');
                k = new Komanda(str[0], str[1]);
                mass.Add(k);
            }
        }

        private void dobavit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 w1 = new Window1();
            w1.Show();
        }
    }
}
