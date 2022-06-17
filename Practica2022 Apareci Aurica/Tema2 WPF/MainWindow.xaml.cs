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

namespace Tema2_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public int Rows { get; set; } = 2;
        public int[,] matrice;
        public List<List<int>> list { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list = new List<List<int>>();
            matrice = RandomEl(Rows, Rows);
            List<int> row;
            lst.Visibility = Visibility.Visible;
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                row = new List<int>();
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    row.Add(matrice[i, j]);
                }
                list.Add(row);
            }
            lst.ItemsSource = list;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int produs = 1;
            int min = int.MaxValue;
            if (matrice == null)
            {
                MessageBox.Show("Matricea nu contine elemente !");
                return;
            }
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                min = int.MaxValue;
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    if (matrice[j, i] < min)
                    {
                        min = matrice[j, i];
                    }
                }
                produs *= min;
            }
            MessageBox.Show($"Produsul elementelor minime de pe fiecare coloana : {produs}");
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            matrice = null;
        }
        private int[,] RandomEl(int row1, int row2)
        {
            int[,] matrix = new int[row1, row2];
            Random el = new Random();
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < row2; j++)
                {
                    matrix[i, j] = el.Next(1, 100);
                }
            }
            return matrix;
        }
    }
}
