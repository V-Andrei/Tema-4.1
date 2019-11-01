namespace Tema_4._1_Ex4
{
    class PizzaBase
    {
        public PizzaBaseName Name { get; set; }
        public int Cost { get; set; }

        public void Print()
        {
            System.Console.WriteLine($"Pizza base name: {Name}and cost: {Cost}");
        }

    }
}
