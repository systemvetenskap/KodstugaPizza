namespace KodstugaPizza
{
    public class Pizza
    {
        public int Number { get; set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        /// <summary>
        /// Skapar en ny pizza av en smarrig sort
        /// </summary>
        /// <param name="name">Namnet på pizzan</param>
        /// <param name="price">Priset på pizzan</param>
        public Pizza(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
