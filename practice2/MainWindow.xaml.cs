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

    WorkWindow workWindow = new WorkWindow();
    private void bLogin_Click(object sender, RoutedEventArgs e)
    {
        Choised = true;
        tbLogin.IsEnabled = true;
        tbPass1.IsEnabled = true;
        tbPass2.IsEnabled = false;
        bEnter.IsEnabled = true;
    }

    private void bRegistration_Click(object sender, RoutedEventArgs e)
    {
        Choised = false;
        tbLogin.IsEnabled = true;
        tbPass1.IsEnabled = true;
        tbPass2.IsEnabled = true;
        bEnter.IsEnabled = true;
    }

    private void bEnter_Click(object sender, RoutedEventArgs e)
    {
        if (Choised == false)
        {
            Registration(tbLogin.Text, tbPass1.Text, tbPass2.Text);
        }
        else
        {
            Logining(tbLogin.Text, tbPass1.Text);
        }
    }

    private void Registration(string tbL, string tbP1, string tbP2)
    {
        if (tbL == "")
        {
            MessageBox.Show("Введите логин");
            return;
        }
        if (tbP1 == tbP2)
        {

        }
        else
        {
            MessageBox.Show("Пароли различны");
            return;
        }

        workWindow.lUser.Content = "Текущий пользователь: " + tbL;
        workWindow.Show();
        Close();
    }

    private void Logining(string tbL, string tbP1)
    {
        if (tbL == "")
        {
            MessageBox.Show("Введите логин");
            return;
        }


        workWindow.lUser.Content = "Текущий пользователь: " + tbL;
        workWindow.Show();
        Close();
    }
}