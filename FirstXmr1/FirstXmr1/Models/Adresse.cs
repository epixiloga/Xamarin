using System;
using System.Collections.Generic;
using System.Text;

namespace FirstXmr1.Models
{
    public class Adresse
    {
		public Adresse(string country, string city)
		{
			Country = country;
			City = city;
		}
		public Adresse()
		{

		}

		public string Country { get; set; }
		public string City { get; set; }
	}
}
