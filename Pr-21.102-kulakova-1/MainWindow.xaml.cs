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
using static System.Net.Mime.MediaTypeNames;

namespace Pr_21._102_kulakova_1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            long number=0;
            Console.WriteLine("Введите двенадцатизначное число:");
            try
            {
 number = long.Parse(tb_number.Text);
                int firstDigit = (int)(number / 1000000000);

            int sum = 0;
            long lastDigits = number % 1000000000;
            while (lastDigits > 0)
            {
                int digit = (int)(lastDigits % 10);
                sum += digit;
                lastDigits /= 10;
            }

            // Проверяем условие
            int product = firstDigit / 100 * (firstDigit / 10 % 10) * (firstDigit % 10);
            bool isEqual = product == sum;
            MessageBox.Show(firstDigit.ToString());
            MessageBox.Show(sum.ToString());
            if (product == sum)
            {
                lbsummary.Content = "числа равны";
            }
            else
            {
                lbsummary.Content = "числа не равны ";
            }
            }
            catch {
                lbsummary.Content = "введено неверно";
            }
           

           
        }
            }

            // Получаем первые 3 десятичные цифры
            
    

    }

