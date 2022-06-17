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

namespace Tema1_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Rezolva(A, B, C);
        }
        private static void Rezolva(int A, int B, int C)
        {
            try
            {
                if (A == 0)
                {
                    MessageBox.Show($"Ecuatia este de gradul I !\nX = {-1 * C / B}");
                    return;
                }
                double delta = Math.Pow(B, 2) - 4 * A * C;
                if (delta < 0)
                {
                    MessageBox.Show("Ecuatia nu are solutii in multimea numerelor reale !");
                    return;
                }
                if (delta == 0)
                {
                    MessageBox.Show($"Ecuatia are o solutie dubla !\nX = {-1 * B / 2 * A:F2} ");
                    return;
                }
                MessageBox.Show($"X1 = {-B - Math.Sqrt(delta) / 2 * A:F2}\nX2 = {-B + Math.Sqrt(delta) / 2 * A:F2}");
            }
            catch (Exception)
            {
                MessageBox.Show("Asigurati-va ca nu are loc impartirea la 0");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
