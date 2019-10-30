namespace Tema_4._1
{
    class Student
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public int Year { get; set; }

        internal string FullDescription
        {
            get { return $" Student name: {Name}, faculty: {Faculty}, year: {Year}."; }
        }
        public void Print()
        {
            System.Console.WriteLine(FullDescription);
        }
    }
}
