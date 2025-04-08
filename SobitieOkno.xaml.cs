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
using static Kursovaya.Prazdniki;

namespace Kursovaya
{
    /// <summary>
    /// Логика взаимодействия для SobitieOkno.xaml
    /// </summary>
    public partial class SobitieOkno : Window
    {
        public class Person
        {
            public string Prazd { get; set; }
            public string Days { get; set; }
        }

        private PriemSobitia priemSobitia; // Один экземпляр
        public SobitieOkno()
        {
            InitializeComponent();
            priemSobitia = new PriemSobitia(); // Инициализация в конструкторе
            Sobitiii(); // Заполняем ListPrazd при запуске
        }

        public void Sobitiii()
        {
        }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        MainWindow main = new MainWindow();
        Hide();
        main.Show();
    }
}
}
