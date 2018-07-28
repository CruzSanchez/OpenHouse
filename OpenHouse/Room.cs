using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouse
{
    class Room
    {
		public Room()
		{
			Descriptions = new List<string>();
			Furnitures = new List<Furniture>();
		}

		public string Name { get; set; }
		public List<string> Descriptions { get; set; }
		public List<Furniture> Furnitures { get; set; }
	}
}
