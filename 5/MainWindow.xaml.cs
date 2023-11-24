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

namespace _5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int f(int n)
        {
            int k = (n - 1 - (n - 1) % 100) / 100;

            return 1 + k;
        }

        private void Year_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int year = int.Parse(Year.Text);

                // в условии целое положительное, тоесть больше нуля
                if (year <= 0)
                {
                    throw new IndexOutOfRangeException();
                }

                int century = f(year);

                Century.Content = $"{century}";
            }

            catch
            {
                Century.Content = "-";
            }

        }
    }
}
