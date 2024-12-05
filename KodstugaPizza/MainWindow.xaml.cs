﻿using System.Windows;

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
        List<Ingredient> ingredients = new List<Ingredient>()
        {
           new Ingredient{Name="skinka", IsVegetrian=false},
           new Ingredient{Name="Mozzarella", IsVegetrian=true},
        };

        Ingredient ingredient = new Ingredient
        {
            Name = "Tomatsås",
            IsVegetrian = true
        };
        ingredients.Add(ingredient);
        Pizza pizza = new Pizza(name: txtTest.Text, price: price, ingredients);
        _resturant.AddNewPizza(pizza);

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