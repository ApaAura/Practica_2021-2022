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

namespace Tema4_WPF
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Aplicatia a fost inchisa !");
            Environment.Exit(0);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string Nume = nume.Text;
                string Prenume = prenume.Text;
                if (Nume.Length == 0)
                {
                    throw new Exception();
                }
                if (Prenume.Length == 0)
                {
                    throw new Exception();
                }
                this.Hide();
                Question w = new Question();
                w.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Nu ati introdus date !");
            }
        }
    }
}
