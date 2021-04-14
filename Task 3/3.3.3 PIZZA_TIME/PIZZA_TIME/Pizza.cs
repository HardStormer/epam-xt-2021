namespace PIZZA_TIME
{
    public class Pizza
    {
        public string Name { get; private set; }
        public int cookingTime { get; private set; }

        public Pizza(string name, int cookingTime)
        {
            this.Name = name;
            this.cookingTime = cookingTime;
        }
    }

    public class PizzaMaker
    {
        public Pizza GetMeat()
        {
            return new Pizza("Мясная", 13);
        }

        public Pizza GetVegan()
        {
            return new Pizza("Веганская", 10);
        }

        public Pizza GetFish()
        {
            return new Pizza("Рыбная", 12);
        }
    }
}
