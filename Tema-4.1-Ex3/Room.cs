namespace Tema_4._1_Ex3
{
    class Room
    {
        public string Name { get; set; }       
        public int Adults { get; set; }
        public int Children { get; set; }

        public Rate DailyRate { get; set; }
        public int numberDays = 2;



        public int GetPriceForDays
        {
           
            get
            {
                return DailyRate.Amount * numberDays;
            }

        }

    }
}
