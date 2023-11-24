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

namespace _4
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


        private void compute()
        {

            try
            {

                int a = int.Parse(A.Text);
                int b = int.Parse(B.Text);
                int c = int.Parse(C.Text);

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }


                int m = (a - a % c) / c;
                int n = (b - b % c) / c;

                Result.Content = $"{n * m}";

            }

            catch
            {
                Result.Content = "-";
            }

        }


        private void A_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }

        private void B_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }

        private void C_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}
