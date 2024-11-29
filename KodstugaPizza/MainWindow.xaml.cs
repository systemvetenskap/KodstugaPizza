using System.Windows;

namespace KodstugaPizza;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    Resturant _resturant = new Resturant();
    private static readonly Random _random = new Random();
    public MainWindow()
    {
        InitializeComponent();
    }
    private string GetFullName(string firstname, string lastname)
    {
        return $"{firstname} {lastname}";
    }
    private void button_Click(object sender, RoutedEventArgs e)
    {
        double price = _random.NextDouble() + 70; // 70 kr + öre 
        Pizza pizza = new Pizza(name: txtTest.Text, price: price);

        _resturant.AddNewPizza(pizza);
        RefreshPizzaMenuListBox();
    }
    private void RefreshPizzaMenuListBox()
    {
        lstPizzas.ItemsSource = null;
        lstPizzas.ItemsSource = _resturant.GetAllPizzas();
    }
}