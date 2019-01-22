using System;
using System.Collections.Generic;
using System.Text;

namespace FirstXmr1.Models
{
    public class Personne
	{
		#region Properties
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public int Age { get; set; }
		#endregion

		#region Constructors
		public Personne()
		{

		}

		public Personne(string firstname, string lastname, int age)
		{
			Firstname = firstname;
			Lastname = lastname;
			Age = age;
		
		}
		#endregion

	}
}
