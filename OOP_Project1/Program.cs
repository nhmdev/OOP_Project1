using System;
using System.Collections.Generic;

namespace OOP_Project1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			List<Dog> dogs = new List<Dog>();
			dogs.Add(new Dog("Thea", "Labrador", 4));
			dogs.Add(new Dog("Tintin", "Miniature Schnauzer", 1));
			dogs.Add(new Dog("Sune", "chiwawa", 3));

			foreach(Dog dog in dogs) {
				Console.WriteLine(dog.GetDogInfo());
			}
		}
	}
}
