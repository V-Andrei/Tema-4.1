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
            List<Room> listRoom = new List<Room>();
            listRoom.Add(new Room { Name = "1", Adults = 2, Children = 1, DailyRate = new Rate { Amount = 200, Currency = "$" } });
            listRoom.Add(new Room { Name = "2", Adults = 1, Children = 1, DailyRate = new Rate { Amount = 100, Currency = "$" } });
            listRoom.Add(new Room { Name = "3", Adults = 2, Children = 2, DailyRate = new Rate { Amount = 50, Currency = "$" } });
            return listRoom;
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
                System.Console.WriteLine("Room amount: "  + r.DailyRate.Amount + r.DailyRate.Currency);
                //r.GetPriceForDays(); 
            }
        }
    }
}
