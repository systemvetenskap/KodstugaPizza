namespace KodstugaPizza
{
    public class IceCreamFactory
    {
        public Icecream? MakeIce(string order, bool hasEatenDinner = true)
        {
            string name;

            name = "Erik";
            if (!hasEatenDinner)
            {
                return null;
            }
            //Icecream icecream = new Icecream()
            //{
            //    Name = order,
            //    Calories=232
            //};

            Icecream icecream = new Icecream(order);
            return icecream;
        }
    }
}
