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
        // vi kan skapa listan direkt med en
        // collection initializer
        List<Ingredient> ingredients = new List<Ingredient>()
        {
           new Ingredient{Name="oregano", IsVegetrian=true},
           new Ingredient{Name="Mozzarella", IsVegetrian=true},
        };

        Ingredient ingredient = new Ingredient
        {
            Name = "Tomatsås",
            IsVegetrian = true
        };
        // eller så lägger vi till ingrediensen styckevis.
        // det senare sättet är det vanligaste eftersom vi sällan
        // känner till vilka saker som ska läggas till på förhand
        ingredients.Add(ingredient);
        Pizza pizza = new Pizza(name: txtTest.Text, price: price, ingredients);
        _resturant.AddNewPizza(pizza);

        /* den här metoden känns onödig eftersom det 
         * är ju smartare att pizzan själv kan svara på om
         * den är vegetarisk eller inte
         */
        bool isVeggie = _resturant.IsPizzaVeggie(pizza);

        RefreshPizzaMenuListBox();
    }
    private void RefreshPizzaMenuListBox()
    {
        lstPizzas.ItemsSource = null;
        lstPizzas.ItemsSource = _resturant.GetAllPizzas();
    }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        // Pizza pizza = new Pizza("garden", 34);
        IceCreamFactory factory = new IceCreamFactory();
        bool eaten = true;
        Icecream? icecream = factory.MakeIce("piggelin", eaten);

        if (icecream is not null)
        {
            MessageBox.Show($"Du fick en {icecream.Name}");
        }
        else
        {
            MessageBox.Show($"Du måste äta middag först");
        }
    }


}