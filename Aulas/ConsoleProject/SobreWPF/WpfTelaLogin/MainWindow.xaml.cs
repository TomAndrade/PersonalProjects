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

namespace WpfTelaLogin
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

        private void buttonEnter_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxUser.Text == "well")
            {
                if (passboxPass.Password == "1234")
                {
                    MessageBox.Show("Login succeed!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    Acesso acesso = new Acesso();
                    acesso.Show();
                }
                else
                {
                    MessageBox.Show("Login failed: incorrect password","Failed",MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Login failed: incorrect user","Failed",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}