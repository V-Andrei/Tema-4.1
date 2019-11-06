using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4._1_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaTopping topping = new PizzaTopping();

            topping.Print();

            PizzaBase pizzaBase = new PizzaBase();
            pizzaBase.Name = BaseNames.Italian;

            Pizza pizza = new Pizza(pizzaBase, "Pizza mea");
            pizza.AddTopping(topping);
            pizza.AddTopping(topping);

            pizzaBase.Print();


            System.Console.ReadLine();
        }
    }
}
