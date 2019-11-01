using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4._1_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel h1 = new Hotel
            {
                Name = "Traian",
                City = "Iasi",
                Stars = 4
            };

            Rate R1 = new Rate
            {
                Amount = 199
            };

            h1.Print();
            System.Console.ReadLine();

        }
    }
}
