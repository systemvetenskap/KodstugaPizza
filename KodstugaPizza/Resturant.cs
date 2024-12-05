namespace KodstugaPizza;

public class Resturant
{
    private List<Pizza> _menu = new List<Pizza>();
    public void AddNewPizza(Pizza pizza)
    {
        _menu.Add(pizza);
    }

    public bool IsPizzaVeggie(Pizza pizza)
    {
        foreach (Ingredient ingredient in pizza.Ingredients)
        {
            if (!ingredient.IsVegetrian)
            {
                return false;
            }
        }

        return true;
    }

    public List<Pizza> GetAllPizzas()
    {
        return _menu;
    }
    public List<Pizza> GetVeggiePizzas()
    {
        List<Pizza> veggies = new List<Pizza>();
        foreach (Pizza pizza in _menu)
        {
            if (pizza.IsVeggie) // eller pizza.IsPizzaVeggie()
            {
                veggies.Add(pizza);
            }
        }
        return veggies;
    }
    public List<Pizza> GetCheapPizzas()
    {
        List<Pizza> cheapPizzas = new List<Pizza>();
        foreach (Pizza pizza in _menu)
        {
            if (pizza.Price <= 70.20)
            {
                cheapPizzas.Add(pizza);
            }
        }
        return cheapPizzas;
    }
}
