using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4._1_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor
            {
                Name = "Anastasiei Ion",
                Faculty = "History",
                Specialization = "Medieval"
            };            
            Course c1 = new Course
            {
                Name = "Preistoria",
                Professor = p1,
                Year = 2,
            };

            c1.Print();

            System.Console.ReadLine();
        }
    }
}
