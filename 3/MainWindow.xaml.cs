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

namespace _3
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

        /*
        
        1 янв - 1 день года
        1 день года - четверг, тоесть имеет номер 4
        2 день года - 5
        3 день - 6
        4 день - 0
        и т.д.

        в терминах функции f сопостовления номера дня к дню в аргументе:

        f(1) = 4
        f(2) = 5
        f(3) = 6
        f(4) = 0
        f(5) = 1
        f(6) = 2
        f(7) = 3
        f(8) = f(1) = 4
        ...

        тоесть функция сопостовления номера к K-ому дню будет:
        
        f(k) = (k + 3) mod 7
        
        */
        private int f(int n)
        {
            return (n + 3) % 7;
        }



        private void K_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                int k = int.Parse(K.Text);

                if (k < 1 || k > 365)
                {
                    throw new ArgumentOutOfRangeException();
                }

                DayOfWeek.Content = $"{f(k)}";

            }

            catch (FormatException)
            {
                DayOfWeek.Content = "-";
            }

            catch (ArgumentOutOfRangeException)
            {
                DayOfWeek.Content = "K вне возм. знач.";
            }

            catch
            {
                DayOfWeek.Content = "-";
            }



        }

    }

}
