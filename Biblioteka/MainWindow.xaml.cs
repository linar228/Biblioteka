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
using System.IO;
using BibliotekaLibrary;

namespace Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Lib lib;
        private List<string> details = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BookBtn_Click(object sender, RoutedEventArgs e)
        {
            TableGrid.Visibility = Visibility.Hidden;
            PazlGrid.Visibility = Visibility.Hidden;
            BookGrid.Visibility = Visibility.Visible;
        }

        private void PazlBtn_Click(object sender, RoutedEventArgs e)
        {
            TableGrid.Visibility = Visibility.Hidden;
            BookGrid.Visibility = Visibility.Hidden;
            PazlGrid.Visibility = Visibility.Visible;
        }

        private void TableBtn_Click(object sender, RoutedEventArgs e)
        {
            BookGrid.Visibility = Visibility.Hidden;
            PazlGrid.Visibility = Visibility.Hidden;
            TableGrid.Visibility = Visibility.Visible;
        }

        private void BookSave_Click(object sender, RoutedEventArgs e)
        {
            lib = LibMaker.Make("B", BookNazvanie.Text);

            details.Clear();
            details.Add(BookAutor.Text);
            details.Add(BookIlustrator.Text);
            details.Add(BookIzdatelstvo.Text);
            details.Add(BookYear.Text);
            details.Add(PazlNazvanie.Text);
            details.Add(PazlElement.Text);
            details.Add(PazlCompany.Text);
            details.Add(TableNazvanie.Text);
            details.Add(TableRazrabotchik.Text);
            details.Add(TableGameplay.Text);
            details.Add(TablePlayers.Text);

            lib.Save(BookNazvanie.Text, details);
        }

        private void PazlSave_Click(object sender, RoutedEventArgs e)
        {
            lib = LibMaker.Make("P", PazlNazvanie.Text);

            details.Clear();
            details.Add(BookAutor.Text);
            details.Add(BookIlustrator.Text);
            details.Add(BookIzdatelstvo.Text);
            details.Add(BookYear.Text);
            details.Add(PazlNazvanie.Text);
            details.Add(PazlElement.Text);
            details.Add(PazlCompany.Text);
            details.Add(TableNazvanie.Text);
            details.Add(TableRazrabotchik.Text);
            details.Add(TableGameplay.Text);
            details.Add(TablePlayers.Text);

            lib.Save(PazlNazvanie.Text, details);
        }

        private void TableSave_Click(object sender, RoutedEventArgs e)
        {
            lib = LibMaker.Make("T", TableNazvanie.Text);

            details.Clear();
            details.Add(BookAutor.Text);
            details.Add(BookIlustrator.Text);
            details.Add(BookIzdatelstvo.Text);
            details.Add(BookYear.Text);
            details.Add(PazlNazvanie.Text);
            details.Add(PazlElement.Text);
            details.Add(PazlCompany.Text);
            details.Add(TableNazvanie.Text);
            details.Add(TableRazrabotchik.Text);
            details.Add(TableGameplay.Text);
            details.Add(TablePlayers.Text);

            lib.Save(TableNazvanie.Text, details);
        }

        private void BookDelete_Click(object sender, RoutedEventArgs e)
        {
            string path = @"H:\book.txt";
            File.Delete(path);
        }

        private void PazlDelete_Click(object sender, RoutedEventArgs e)
        {
            string path = @"H:\pazl.txt";
            File.Delete(path);
        }

        private void TableDelete_Click(object sender, RoutedEventArgs e)
        {
            string path = @"H:\table.txt";
            File.Delete(path);
        }

    }
}
