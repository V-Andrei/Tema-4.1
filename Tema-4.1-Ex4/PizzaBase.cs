namespace Tema_4._1_Ex4
{
    public class PizzaBase
    {
        public BaseNames Name { get; set;}

        private decimal _baseCost = 8m;
        public decimal Cost 
        { 
            get
            {
                if (Name == BaseNames.Italian)
                {
                    return 1.5m * _baseCost;
                }

                return _baseCost;
            }
        }


        public void Print()
        {
            System.Console.WriteLine($"Base:[{Name}] ($[{Cost}])");
        }

    }
}
