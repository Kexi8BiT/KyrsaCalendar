using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
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
using System.Windows.Shapes;

namespace Kursovaya
{
    /// <summary>
    /// Логика взаимодействия для Prazdniki.xaml
    /// </summary>
    public partial class Prazdniki : Window
    {
        public class Person
        {
            public string Prazd { get; set; }
            public string Date { get; set; }
            public string Days { get; set; }
        }
        public Prazdniki()
        {
            InitializeComponent();
            List();
        }
        // Вычисляем сколько дней до праздника
        public int[] Day()
        {
            
            DateTime Day1 = DateTime.Today;                                                                                   // Сегодняшняя дата
            DateTime pr1 = new DateTime(DateTime.Now.Year, 1, 1);                                                             // Дата из которой вычитаем
            DateTime pr2 = new DateTime(DateTime.Now.Year, 1, 7);                                                             // Дата из которой вычитаем
            DateTime pr3 = new DateTime(DateTime.Now.Year, 1, 13);                                                            // Дата из которой вычитаем
            DateTime pr4 = new DateTime(DateTime.Now.Year, 1, 25);                                                            // Дата из которой вычитаем
            DateTime pr5 = new DateTime(DateTime.Now.Year, 2, 14);                                                            // Дата из которой вычитаем
            DateTime pr6 = new DateTime(DateTime.Now.Year, 2, 23);                                                            // Дата из которой вычитаем
            DateTime pr7 = new DateTime(DateTime.Now.Year, 3, 8);                                                             // Дата из которой вычитаем
            DateTime pr8 = new DateTime(DateTime.Now.Year, 3, 26);                                                            // Дата из которой вычитаем
            DateTime pr9 = new DateTime(DateTime.Now.Year, 5, 1);                                                             // Дата из которой вычитаем
            DateTime pr10 = new DateTime(DateTime.Now.Year, 5, 9);                                                            // Дата из которой вычитаем
            DateTime pr11 = new DateTime(DateTime.Now.Year, 5, 12);                                                           // Дата из которой вычитаем
            DateTime pr12 = new DateTime(DateTime.Now.Year, 11, 4);                                                           // Дата из которой вычитаем


            TimeSpan res1 = pr1 - Day1;                                                                                       // Вычитаем определенную дату из сегодняшней
            TimeSpan res2 = pr2 - Day1;                                                                                       // Вычитаем определенную дату из сегодняшней
            TimeSpan res3 = pr3 - Day1;                                                                                       // Вычитаем определенную дату из сегодняшней
            TimeSpan res4 = pr4 - Day1;                                                                                       // Вычитаем определенную дату из сегодняшней
            TimeSpan res5 = pr5 - Day1;                                                                                       // Вычитаем определенную дату из сегодняшней
            TimeSpan res6 = pr6 - Day1;                                                                                       // Вычитаем определенную дату из сегодняшней
            TimeSpan res7 = pr7 - Day1;                                                                                       // Вычитаем определенную дату из сегодняшней
            TimeSpan res8 = pr8 - Day1;                                                                                       // Вычитаем определенную дату из сегодняшней
            TimeSpan res9 = pr9 - Day1;                                                                                       // Вычитаем определенную дату из сегодняшней
            TimeSpan res10 = pr10 - Day1;                                                                                     // Вычитаем определенную дату из сегодняшней
            TimeSpan res11 = pr11 - Day1;                                                                                     // Вычитаем определенную дату из сегодняшней
            TimeSpan res12 = pr12 - Day1;                                                                                     // Вычитаем определенную дату из сегодняшней


            int d1 = res1.Days;                                                                                               // Получаем количество дней
            int d2 = res2.Days;                                                                                               // Получаем количество дней
            int d3 = res3.Days;                                                                                               // Получаем количество дней
            int d4 = res4.Days;                                                                                               // Получаем количество дней
            int d5 = res5.Days;                                                                                               // Получаем количество дней
            int d6 = res6.Days;                                                                                               // Получаем количество дней
            int d7 = res7.Days;                                                                                               // Получаем количество дней
            int d8 = res8.Days;                                                                                               // Получаем количество дней
            int d9 = res9.Days;                                                                                               // Получаем количество дней
            int d10 = res10.Days;                                                                                             // Получаем количество дней
            int d11 = res11.Days;                                                                                             // Получаем количество дней
            int d12 = res12.Days;                                                                                             // Получаем количество дней

            int[] result = new int[12] {d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12 };                                  // массив для хранения дней


            for (int i = 0; i < 12; i++)
            {
                // Добавляет 365 дней если дата уже прошла
                if (result[i] < 0)
                {
                    result[i] += 365;
                }

            }
            
            return result;
        }
        // Выводим лист праздников
        public void List()
        {
            int []day = Day();
            List<Person> people = new List<Person>
            {
                new Person { Prazd = "Новый год", Date = "1 янавря", Days = $"{day[0]} дней до праздника" },                  // Новый год
                new Person { Prazd = "Рождество", Date = "7 янавря", Days = $"{day[1]} дней до праздника" },                  // Рождество
                new Person { Prazd = "Старый Новый Год", Date = "13 янавря", Days = $"{day[2]} дней до праздника" },          // Старый НГ
                new Person { Prazd = "Татьянин день", Date = "25 янавря", Days = $"{day[3]} дней до праздника" },             // Татьянка
                new Person { Prazd = "День Святого Валентина", Date = "14 февраля", Days = $"{day[4]} дней до праздника" },   // 14 февраля
                new Person { Prazd = "День защитника отечества", Date = "23 февраля", Days = $"{day[5]} дней до праздника" }, // 23 февраля
                new Person { Prazd = "Международный женский день", Date = "8 марта", Days = $"{day[6]} дней до праздника" },  // 8 марта
                new Person { Prazd = "День Матери", Date = "26 марта", Days = $"{day[7]} дней до праздника" },                // День матери
                new Person { Prazd = "Праздник Весны и Труда", Date = "1 мая", Days = $"{day[8]} дней до праздника" },        // День труда
                new Person { Prazd = "День Победы", Date = "9 мая", Days = $"{day[9]} дней до праздника" },                   // День победы
                new Person { Prazd = "День России", Date = "12 мая", Days = $"{day[10]} дней до праздника" },                  // День России
                new Person { Prazd = "День международного единства", Date = "4 ноября", Days = $"{day[11]} дней до праздника" },// День международного единства

            };
            ListPrazd.ItemsSource = people;
        }
        // Возвращение в главное меню 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            Hide();
            main.Show();
        }
    }
}
