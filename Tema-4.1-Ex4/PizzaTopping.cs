using System;

namespace Tema_4._1_Ex4
{
    class PizzaTopping
    {
        public PizzaToppingName Name { get; set; }
        public int Cost;

        public void Print ()
        {
            Console.WriteLine($"Pizza topping name: {Name} and cost {Cost}");
        }

    }
}
