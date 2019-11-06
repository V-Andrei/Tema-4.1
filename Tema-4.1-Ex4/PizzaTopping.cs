using System;

namespace Tema_4._1_Ex4
{
    public class PizzaTopping
    {
        private ToppingsNames _name;
        public ToppingsNames Name
        {
            get
            {
                return _name;
            }
            set
            {   
                if(value == ToppingsNames.Cheese || value == ToppingsNames.Vegetable || value== ToppingsNames.Meat)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Please enter a correct value.");
                }
                
            }
        }

        public decimal Cost 
        {
            get
            {
                switch (Name)
                {
                    case ToppingsNames.Cheese:
                        return 12;
                    case ToppingsNames.Meat:
                        return 20;
                    default:
                        return 10;
                }
            }
        }

        public void Print ()
        {
            string toppingName = this.Name.ToString();
            if (Name == ToppingsNames.Meat)
            {
                Console.WriteLine($"{this.Name.ToString().ToUpper()} (${this.Cost})");
            }
            else
            {
                Console.WriteLine($"{this.Name} (${this.Cost})");
            }           
        }
    }
}
