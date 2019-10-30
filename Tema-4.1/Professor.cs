using System;

namespace Tema_4._1
{
    class Professor
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }

        internal string FullDescription
        {
            get { return $"Professor name: {Name}, faculty: {Faculty}, specialization: {Specialization}."; }
        }
        public void Print()
        {
            System.Console.WriteLine(FullDescription);
        }
    }
}
