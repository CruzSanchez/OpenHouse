using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouse
{
	class Realtor
	{
		public string Name { get; set; }

		public void Speak(string message)
		{
			Console.WriteLine(message);
		}

		public bool UserAnswersYes(string question)
		{
			Speak(question);
			string response = Console.ReadLine();

			return response == "yes";

		}

		public void DescribeRoom(Room room)
		{
			speakAllDescriptions(room.Descriptions);	
		}

		public void DescribeFurniture(Room room)
		{
			foreach (Furniture piece in room.Furnitures)
			{
				speakAllDescriptions(piece.Descriptions);
			}
		}

		private void speakAllDescriptions(List<string> descriptions)
		{
			foreach(string description in descriptions)
			{
				Speak(description);
			}
		}
	}
}