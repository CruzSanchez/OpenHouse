using System;

namespace OpenHouse
{
	class Program
	{
		static void Main(string[] args)
		{
			House house = new House();
			house.Address = "1833 Linthicum Circle";

			Realtor agent = new Realtor();
			agent.Name = "Taj";

			Room thekitchen = new Room();
			thekitchen.Name = "The Kitchen";
			thekitchen.Descriptions.Add("Is clean and white.");
			thekitchen.Descriptions.Add("It's nice and big.");
			Furniture sink = new Furniture();
			sink.Descriptions.Add("The sink is very nasty.");
			sink.Descriptions.Add("It has jets.");


			Room thelivingroom = new Room();
			thelivingroom.Name = "The Living Room";
			thelivingroom.Descriptions.Add("It has plenty of room for furniture.");
			Furniture sofa = new Furniture();
			sofa.Descriptions.Add("It is really comfy");


			Room masterbedroom = new Room();
			masterbedroom.Name = "Master bedroom";
			masterbedroom.Descriptions.Add("There is a big TV in here.");
			Furniture TV = new Furniture();
			TV.Descriptions.Add("It's a 4k UHD.");

			house.Rooms.Add(thekitchen);
			house.Rooms.Add(thelivingroom);
			house.Rooms.Add(masterbedroom);
			thekitchen.Furnitures.Add(sink);
			thelivingroom.Furnitures.Add(sofa);
			masterbedroom.Furnitures.Add(TV);


			agent.Speak($"Hello! Welcome to {house.Address} your future home. My name is {agent.Name}.");
			
			foreach(Room room in house.Rooms)
			{
				if(agent.UserAnswersYes($"Would you like to see {room.Name}?"))
				{
					agent.DescribeRoom(room);
					agent.DescribeFurniture(room);
				}
				Console.ReadLine();
			}

			
		}
	}
}
