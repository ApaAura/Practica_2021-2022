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
using System.Windows.Shapes;

namespace Tema3_WPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window, INotifyPropertyChanged
    {
        public List<Biblioteca> Carti { get; set; }
        public Window1(List<Biblioteca> carti)
        {
            Carti = carti;
            InitializeComponent();
            this.DataContext = this;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public int selected { get; set; } = 0;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                List<Biblioteca> s = (from c in Carti where c.Anul_Aparitiei.Year >= selected orderby c.Autorul select c).ToList();
                CartiDataGrid.ItemsSource= s;
            }
            catch (Exception)
            {
                MessageBox.Show("Introduceti date valide !");
            }
        }
    }
}
