using System;
namespace OOP_Project1
{
	public class Dog
	{
		public int Age { get; set; }
		public string Breed { get; set; }
		public string Name { get; set; }

		public Dog(string name, string breed, int age)
		{
			this.Age = age;
			this.Breed = breed;
			this.Name = name;
		}

		public string GetDogInfo()
		{
			string ret =
				"***** " + Name + " *****\n" + 
				"Breed: " + Breed + "\n" +
				"Age: " + Age + "\n" +
				"******";
			for (int i = 0; i < Name.Length; i++){
				ret += "*";
			}
			ret += "******\n";
			return ret;
		}

	}
}
