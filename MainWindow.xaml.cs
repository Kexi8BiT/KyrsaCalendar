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

namespace Kursovaya
{
    public partial class MainWindow : Window
    {
        private PriemSobitia priemSobitia;
        private MainViewModel viewModel;

        public MainWindow()
        {
            priemSobitia = new PriemSobitia();
            viewModel = new MainViewModel();
            InitializeComponent();

            this.DataContext = viewModel;

            // Добавляем даты и проверяем

            viewModel.HighlightedDatesSet.Add(new DateTime(2025, 4, 10));
            viewModel.HighlightedDatesSet.Add(new DateTime(2025, 4, 15));
            viewModel.HighlightedDatesSet.Add(new DateTime(2025, 4, 20));
            MessageBox.Show($"Dates in collection: {viewModel.HighlightedDatesSet.Count}");
            MessageBox.Show($"Dates in HighlightedDatesSet: {string.Join(", ", viewModel.HighlightedDatesSet.Select(d => d.ToShortDateString()))}");
            calendar1.DisplayDate = new DateTime(2025, 4, 1);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Дополнительная инициализация, если нужно
        }

        private void Goroskop_Button(object sender, RoutedEventArgs e)
        {
            Goroskop goroskop = new Goroskop();
            Hide();
            goroskop.Show();
        }

        private void Spravra_Click(object sender, RoutedEventArgs e)
        {
            // Логика для кнопки "i"
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
            if (!string.IsNullOrEmpty(message) && eventDate.SelectedDate.HasValue)
            {
                viewModel.HighlightedDatesSet.Add(eventDate.SelectedDate.Value);
                MessageBox.Show($"Added date: {eventDate.SelectedDate.Value.ToShortDateString()}");
            }
            TexSob.Clear();
        }

        private void Sobit_Button(object sender, RoutedEventArgs e)
        {
            SobitieOkno sobiti = new SobitieOkno();
            Hide();
            sobiti.Show();
        }
    }
}