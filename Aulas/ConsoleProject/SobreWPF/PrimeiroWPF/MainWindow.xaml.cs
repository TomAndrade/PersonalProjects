using Microsoft.Win32;
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

namespace PrimeiroWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pass1.Visibility = Visibility.Collapsed;
        }

        private void datePicker1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            labelMostraData.Content = datePicker1.SelectedDate.ToString();
        }

        private void buttonAbreArquivo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "C:\\";
            openFile.Filter = "Arquivos de texto|*.txt|Arquivos PDF|*.pdf";
            if (openFile.ShowDialog() == true)
            {
                textBoxCaminho.Text = openFile.FileName;
            }
            
        }
    }
}