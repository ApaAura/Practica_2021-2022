using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Tema3_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public List<Biblioteca> carti { get; set; }
        public Biblioteca Biblioteca { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            carti = new List<Biblioteca>();
            Biblioteca = new Biblioteca();
            this.DataContext = this;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void Inregistrare_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                carti.Add(Biblioteca);
                MessageBox.Show($"Cartea a fost inregistrata cu succes !");
                Biblioteca = new Biblioteca();
                Biblioteca.ID = carti.Count;
                IdTBox.Text = carti.Count.ToString();
                CartiDataGrid.Items.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Introduceti date valide !");
            }
        }
        private void Salvare_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                if (carti.Count != 0)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream("date.txt", FileMode.Create)))
                    {
                        sw.WriteLine(carti.Count);
                        foreach (var item in carti)
                        {
                            sw.WriteLine($"{item.ID}_{item.Autorul}_{item.Titlu}_{item.Editura}_{item.Anul_Aparitiei}_{item.NrPagini}");
                        }
                    }
                    MessageBox.Show("Fisierul a fost creat cu succes !");
                }
                else
                {
                    MessageBox.Show("Asigurati-va ca a-ti inregistrat cartile mai intai.");
                }
            }
            catch (Exception)
            { MessageBox.Show("Ceva nu a mers cum trebuie, m-ai incercati o data"); }
        }
        private void Deschide_Click_4(object sender, RoutedEventArgs e)
        {
            carti = new List<Biblioteca>();
            if (File.Exists("date.txt"))
            {
                if (File.ReadAllText("date.txt") != null)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(new FileStream("date.txt", FileMode.Open)))
                        {
                            int nr = int.Parse(sr.ReadLine());
                            string[] linie = null;
                            for (int i = 0; i < nr; i++)
                            {
                                linie = sr.ReadLine().Split("_");
                                carti.Add(new Biblioteca(carti.Count, linie[1], linie[2], linie[3], DateTime.Parse(linie[4]), int.Parse(linie[5])));
                                IdTBox.Text = carti.Count.ToString();
                            }
                        }
                    }
                    catch (Exception)
                    { MessageBox.Show("Fisierul a fost gasit, insa nu este formatat corect."); }
                }
                else { MessageBox.Show("Fisierul a fost gasit, insa nu este formatat corect."); }
            }
            else { MessageBox.Show("Fisierul nu a fost gasit."); }
            CartiDataGrid.Items.Refresh();
        }
        private void Sortare_Click_5(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1(carti);
            window1.ShowDialog();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
