using System.Collections.Generic;

namespace Tema_4._1
{
    class Course
    {
        public string Name { get; set; }
        public Professor Professor { get; set; }
        public int Year { get; set; }
        public List<Student> Students { get; set; }


        internal string FullDescription
        {
            get { return $"Course name: {Name}, Course year: {Year}"; }
        }
        
        private static List<Student> StudentList()
        {
            List<Student> l1 = new List<Student>();
            l1.Add(new Student { Name = "Maria", Faculty = "History", Year = 2 });
            l1.Add(new Student { Name = "Vasile", Faculty = "History", Year = 3 });
            return l1;
        }

        public void Print()
        {
            List<Student> l1 = StudentList();

            System.Console.WriteLine(FullDescription);
            Professor.Print();
            foreach (Student a in l1)
            {
                System.Console.Write("Student name: " + a.Name);
                System.Console.Write(" faculty: " + a.Faculty);
                System.Console.Write(" year: "+ a.Year + "\n");
            }
        }
    }
}
