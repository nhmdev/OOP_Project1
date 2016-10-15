using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Project1
{
	class MainClass
	{


		public static void Main(string[] args)
		{
			List<Dog> dogs = new List<Dog>();
			int nextDogId = 1;

			while (true)
			{
				int menuChoice = ShowMenu();

				switch (menuChoice)
				{
					case 1:
						// Add new dog
						Dog dog = NewDog();
						dog.SetId(nextDogId);
						nextDogId++;
						dogs.Add(dog);
						break;
					case 2:
						// Remove a dog
						if (dogs.Count > 0)
						{
							Dog dogR = RemoveDog(dogs);
							dogs.Remove(dogR);
						}
						else 
						{
							Console.WriteLine("There are no dogs in list.");
						}
						break;
					case 3:
						// Show info
						if (dogs.Count > 0)
						{
							foreach (Dog dogI in dogs)
							{
								Console.WriteLine(dogI.GetDogInfo());
							}
						}
						else
						{
							Console.WriteLine("There are no dogs in list.");
						}
						break;
					case 4: Environment.Exit(0); break;
				}
			}






		}

		public static int ShowMenu()
		{

			Console.WriteLine("***** Show Dogs *****");
			Console.WriteLine("* 1. Add new dog    *");
			Console.WriteLine("* 2. Remove a dog   *");
			Console.WriteLine("* 3. Show info      *");
			Console.WriteLine("* 4. Exit           *");
			Console.WriteLine("*********************");
			Console.Write("What do you want to do? ");
			string input = Console.ReadLine();
			bool validMenuChoice = false;
			int inputAsInt = -1;
			while (!validMenuChoice)
			{
				bool validInt;
				// Try parse to int
				validInt = int.TryParse(input, out inputAsInt);
				if (validInt)
				{
					if (inputAsInt > 0 && inputAsInt < 5)
					{
						validMenuChoice = true;
					}
					else {
						validMenuChoice = false;
					}
				}
				if (validInt == false || validMenuChoice == false)
				{
					Console.WriteLine("Choose a valid alternative (1 - 4): ");
					input = Console.ReadLine();
				}
			}
			return inputAsInt;
		}

		public static Dog NewDog()
		{
			Console.WriteLine("********** Add a new dog **********");
			Console.Write("Choose a name: ");
			string name = Console.ReadLine();
			if (name.Length == 0)
			{
				name = "Unknown";
			}
			Console.Write("Choose a breed: ");
			string breed = Console.ReadLine();
			if (breed.Length == 0)
			{
				breed = "Unknown";
			}
			Console.Write("Choose an age: ");
			string age = Console.ReadLine();
			int ageAsInt;
			while (!int.TryParse(age, out ageAsInt))
			{
				Console.WriteLine("Age is not a number. Try again: ");
				age = Console.ReadLine();
			}

			return new Dog(name, breed, ageAsInt);

		}

		public static Dog RemoveDog(List<Dog> dogs)
		{
			Console.WriteLine("********** Remove a dog **********");
			Console.Write("Choose dog id: ");
			string id = Console.ReadLine();
			int idAsInt;
			bool validDogId = false;
			Dog dog = null;
			while (!validDogId)
			{
				bool validInt = int.TryParse(id, out idAsInt);
				if (validInt)
				{
					dog = dogs.SingleOrDefault(d => d.HumanReadableId == idAsInt);

					if (dog != null)
					{
						validDogId = true;
					}
					else
					{
						validDogId = false;
					}

				}

				if (!validDogId)
				{
					Console.Write("Not valid id. Try again: ");
					id = Console.ReadLine();
				}

			}

			return dog;
		}
	}
}
