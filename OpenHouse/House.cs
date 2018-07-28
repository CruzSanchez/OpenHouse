using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouse
{
    class House
    {
		public string Address { get; set; }
		public List<Room> Rooms { get; set; }

		public House()
		{
			Rooms = new List<Room>();
		}
    }
}
