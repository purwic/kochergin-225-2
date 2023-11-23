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

namespace kochergin_225_2
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

        private void Number_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {

                double digit_1 = double.Parse($"{Number.Text[0]}");
                double digit_2 = double.Parse($"{Number.Text[1]}");

                Sum.Content = $"{digit_1 + digit_2}";
                Product.Content = $"{digit_1 * digit_2}";

            }
            catch
            {
                Sum.Content = "-";
                Product.Content = "-";
            }

        }
    }
}
