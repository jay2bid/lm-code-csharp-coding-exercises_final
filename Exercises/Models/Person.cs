using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Exercises.Models;

namespace Exercises.Models
{
	public class Person
    {

		public string firstName;
		public string lastName;
		public string city;
		public int  age;

        public Person()
		{
		}
        public Person(string FirstName, string LastName, string City, int Age)
        {

        firstName = FirstName;
        lastName = LastName;
        city = City;
        age = Age;

    }
    }
}

