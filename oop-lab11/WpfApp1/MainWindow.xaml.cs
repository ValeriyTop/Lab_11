using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Номер телефону
        private void buttonTel_Click(object sender, RoutedEventArgs e)
        {
            
            Regex reg = new Regex(@"^\+380\d{9}$");
            if(reg.IsMatch(textBoxTel.Text))
            {
                labelTel.Content = "ОК";
                labelTel.Foreground = Brushes.Green;
                
            }
            else
            {
                labelTel.Foreground = Brushes.Red;
                labelTel.Content = "ПОМИЛКА";
            }
        }

        private void buttonPass_Click(object sender, RoutedEventArgs e)
        {
            // Номер паспорта
            Regex reg = new Regex(@"^(([А-ЯІЄЇ]{2}\d{9})|(\d{9}))$");
            if (reg.IsMatch(textBoxPass.Text))
            {
                labelPass.Content = "ОК";
                labelPass.Foreground = Brushes.Green;
            }
            else
            {
                labelPass.Foreground = Brushes.Red;
                labelPass.Content = "ПОМИЛКА";
            }
        }

        private void buttonNum_Click(object sender, RoutedEventArgs e)
        {
            //Цифри
            Regex reg = new Regex(@"^[2-7]((222[2-9])|([2-7][0-7][0-7][0-7]|7[0-7][0-7][0-7]))$");
            if (reg.IsMatch(textBoxNum.Text))
            {
                labelNum.Content = "ОК";
                labelNum.Foreground = Brushes.Green;
            }
            else
            {
                labelNum.Foreground = Brushes.Red;
                labelNum.Content = "ПОМИЛКА";
            }
        }

        private void buttonUkr_Click(object sender, RoutedEventArgs e)
        {
            // Ім'я
            Regex reg = new Regex(@"^[A-Яа-яіІєЄїЇ]{2,}$");
            if (reg.IsMatch(textBoxUkr.Text))
            {
                labelUkr.Content = "ОК";
                labelUkr.Foreground = Brushes.Green;
            }
            else
            {
                labelUkr.Foreground = Brushes.Red;
                labelUkr.Content = "ПОМИЛКА";
            }
        }

        private void buttonTime_Click(object sender, RoutedEventArgs e)
        {
            // Година
            Regex reg = new Regex(@"^\d{2}:\d{2}$");
            if (reg.IsMatch(textBoxTime.Text))
            {
                labelTime.Content = "ОК";
                labelTime.Foreground = Brushes.Green;
            }
            else
            {
                labelTime.Foreground = Brushes.Red;
                labelTime.Content = "ПОМИЛКА";
            }
        }

        private void buttonEmail_Click(object sender, RoutedEventArgs e)
        {
            // Пошта
            Regex reg = new Regex(@"\w+@\w+\.\w+", RegexOptions.IgnoreCase);
            if (reg.IsMatch(textBoxEmail.Text))
            {
                labelEmail.Content = "ОК";
                labelEmail.Foreground = Brushes.Green;
            }
            else
            {
                labelEmail.Foreground = Brushes.Red;
                labelEmail.Content = "ПОМИЛКА";
            }
        }
    }
}
