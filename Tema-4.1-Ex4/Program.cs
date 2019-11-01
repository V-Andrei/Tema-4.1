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

        }
    }
    public enum PizzaToppingName
    {
        Cheese, Meat, Vegetable
    }
    public enum PizzaBaseName
    {
        Regular, Thick, Italian
    }
    class Pizza
    {
        public PizzaBase pizzaBase { get; set; }
        public List<PizzaTopping> pizzaToppings { get; set; }

    }
}
