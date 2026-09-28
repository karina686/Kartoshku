using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Reflection.Metadata.BlobBuilder;

namespace Kartoshku
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Kets> kets = new ObservableCollection<Kets>();
        Kets selectKets = new Kets();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void StackPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            StackPanel s = new StackPanel();
            s = (StackPanel)sender;
            s.Background = Brushes.DarkGray;
        }

        private void StackPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            StackPanel s = new StackPanel();
            s = (StackPanel)sender;
            s.Background = Brushes.Beige;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((sender as StackPanel).DataContext is Kets ket)
            {
                txtTaken.Text = ket.Taken.ToString(); 
                txtCount.Text = ket.Count.ToString();
                txtPrice.Text = ket.Price.ToString();
                txtYear.Text = ket.Year.ToString();
                txtName.Text = ket.Name.ToString();

                selectKets = ket;
            }

        }
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (selectKets != null)
                kets.Remove(selectKets);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delif_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Addlif_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}