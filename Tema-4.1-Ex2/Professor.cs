using System;

namespace Tema_4._1_Ex2
{
    class Professor
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }

        internal string FullDescription
        {
            get { return $"Professor name: {Name}, Faculty: {Faculty}, Specialization: {Specialization}."; }
        }
        public void Print()
        {
            System.Console.WriteLine(FullDescription);
        }
    }
}
