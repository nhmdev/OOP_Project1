using System;
namespace OOP_Project1
{
	public class Dog
	{
		int humanReadableId;
		public int Age { get; set; }
		public string Breed { get; set; }
		public string Name { get; set; }
		public int HumanReadableId { 
			get { return humanReadableId;}
			}
		Guid id;


		public Dog(string name, string breed, int age)
		{
			this.Age = age;
			this.Breed = breed;
			this.Name = name;
			this.id = Guid.NewGuid();
		}

		public void SetId(int id){
			humanReadableId = id;
		}

		public string GetDogInfo()
		{
			string ret =
				"***** " + Name + " *****\n" +
				"Id:    " + HumanReadableId + "\n" +
				"Breed: " + Breed + "\n" +
				"Age:   " + Age + "\n" +
				"******";
			for (int i = 0; i < Name.Length; i++){
				ret += "*";
			}
			ret += "******\n";
			return ret;
		}

	}
}
