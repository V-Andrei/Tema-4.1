using System.Collections.Generic;

namespace Tema_4._1_Ex3
{
    class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Stars { get; set; }
        

        private static List<Room> RoomsList()
        {
            List<Room> listRoom1 = new List<Room>();
            listRoom1.Add(new Room { Name = "10", Adults = 2, Children = 1, }) ;
            return listRoom1;
        }

        public void Print()
        {
            List<Room> listRoom1 = RoomsList();
            System.Console.WriteLine($"Hotel name: {Name}, City: {City}, Stars: {Stars}");
            foreach(Room r in listRoom1)
            {
                System.Console.WriteLine("Room name: " + r.Name);
                System.Console.WriteLine("Number adults: " + r.Adults);
                System.Console.WriteLine("Number children: " + r.Children);
                System.Console.WriteLine("DailyRate: " + r.GetPriceForDays);              
            }
        }
    }
}
