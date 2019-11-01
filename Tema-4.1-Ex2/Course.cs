using System.Collections.Generic;

namespace Tema_4._1_Ex2
{
    class Course
    {
        public string Name { get; set; }
        public Professor Professor { get; set; }
        public int Year { get; set; }
           
        private static List<Student> StudentList()
        {
            List<Student> listStud1 = new List<Student>();
            listStud1.Add(new Student { Name = "Maria", Faculty = "History", Year = 2 });
            listStud1.Add(new Student { Name = "Vasile", Faculty = "History", Year = 3 });
            return listStud1;
        }

        public void Print()
        {
            List<Student> listStud1 = StudentList();

            System.Console.WriteLine($"Course name: {Name}, Course year: {Year}");
            Professor.Print();
            foreach (Student s in listStud1)
            {
                System.Console.Write("Student name: " + s.Name);
                System.Console.Write(" Faculty: " + s.Faculty);
                System.Console.Write(" Year: "+ s.Year + "\n");
            }
        }
    }
}
