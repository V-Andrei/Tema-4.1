namespace Tema_4._1_Ex2
{
    class Student
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public int Year { get; set; }

        internal string FullDescription
        {
            get { return $" Student name: {Name}, Faculty: {Faculty}, Year: {Year}."; }
        }
        public void Print()
        {
            System.Console.WriteLine(FullDescription);
        }
    }
}
