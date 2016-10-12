using System;

namespace OOP_Project1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Dog dog1 = new Dog("Thea", "Labrador", 4);
			Dog dog2 = new Dog("Tintin", "Miniature Schnauzer", 1);
			Dog dog3 = new Dog("Sune", "chiwawa", 3);

			Console.WriteLine(dog1.GetDogInfo());
			Console.WriteLine(dog2.GetDogInfo());
			Console.WriteLine(dog3.GetDogInfo());
		}
	}
}
