using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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

namespace Kursovaya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PriemSobitia priemSobitia;

        public MainWindow()
        {
            priemSobitia = new PriemSobitia(); // Инициализируем экземпляр в конструкторе
            InitializeComponent();
            
        }

        private void Goroskop_Button(object sender, RoutedEventArgs e)
        {
            Goroskop goroskop = new Goroskop();
            Hide();
            goroskop.Show();
        }

        private void Spravra_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Prazdniki_Button(object sender, RoutedEventArgs e)
        {
            Prazdniki prazdniki = new Prazdniki();
            Hide();
            prazdniki.Show();
        }

        private void Dobawsob_Button(object sender, RoutedEventArgs e)
        {
            string message = TexSob.Text;

            TexSob.Clear(); // Очистка TextBox после отправки

        }

        private void Sobit_Button(object sender, RoutedEventArgs e)
        {
            SobitieOkno sobiti = new SobitieOkno();
            Hide();
            sobiti.Show();
        }
    }
}
