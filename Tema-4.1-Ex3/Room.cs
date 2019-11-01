namespace Tema_4._1_Ex3
{
    class Room
    {
        public string Name { get; set; }       
        public int Adults { get; set; }
        public int Children { get; set; }
        public Rate DailyRate { get; set; }


        public void GetPriceForDays()
        {

            System.Console.WriteLine("How many days?");
            int nrDays = System.Convert.ToInt32(System.Console.ReadLine());

            int totalDays = DailyRate.Amount * nrDays;
            System.Console.WriteLine(totalDays + DailyRate.Currency);
        }

    }
}
