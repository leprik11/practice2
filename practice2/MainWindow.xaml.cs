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

namespace practice2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    bool Choised = false;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void bLogin_Click(object sender, RoutedEventArgs e)
    {

    }

    private void bRegistration_Click(object sender, RoutedEventArgs e)
    {
        Choised = false;
        tbLogin.IsEnabled = true;
        tbPass1.IsEnabled = true;
        tbPass2.IsEnabled = true;
        bEnter.IsEnabled = true;
    }
}