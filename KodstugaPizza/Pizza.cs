namespace KodstugaPizza
{
    public class Pizza
    {
        public int Number { get; set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        /// <summary>
        /// Skapar en ny pizza av en smarrig sort
        /// </summary>
        /// <param name="name">Namnet på pizzan</param>
        /// <param name="price">Priset på pizzan</param>
        public Pizza(string name, double price, List<Ingredient> ingredients)
        {
            Name = name;
            Price = price;
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
