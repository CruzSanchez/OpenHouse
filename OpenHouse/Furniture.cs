using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouse
{
    class Furniture
    {
		public Furniture()
		{
			Descriptions = new List<string>();
		}

		public string Name { get; set; }
		public List<string> Descriptions { get; set; }
	}
}
