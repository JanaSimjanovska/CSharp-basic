using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkLinq
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
            new Person("Alice","Thompson", 18, 'F'),
            new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			// Task 01
			// all people aged 50 or more

			List<Person> peopleAged50OrMore = people
									.Where(person => person.Age >= 50)
									.ToList();

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("List of all people aged 50 or more:");
			peopleAged50OrMore.ForEach(person => Console.WriteLine($"{person.FirstName} {person.LastName}"));

			// Task 02
			// all people name starts with B

			List<Person> peopleWhoseNameStartsWithB = people
											.Where(person => person.FirstName.StartsWith("B"))
											.ToList();

			Console.WriteLine("---------------------------------------------------");
			Console.WriteLine("List of all people whose name starts with a B:");
			peopleWhoseNameStartsWithB.ForEach(person => Console.WriteLine($"{person.FirstName}"));

			// Task 03
			// first person whose surname starts with T

			Person firstPersonWhoseSurnameStartsWithT = people
												.Where(person => person.LastName.StartsWith("T"))
												.FirstOrDefault();

			Console.WriteLine("---------------------------------------------------");
			Console.WriteLine($"First person on the list whose last name starts with a T is {firstPersonWhoseSurnameStartsWithT.FirstName} {firstPersonWhoseSurnameStartsWithT.LastName}.");

			// Task 04
			// find youngest and oldest person

			// Youngest person/s
			int youngestPersonsAge = people
								.Min(person => person.Age);


			// Ova go pravam vo slucaj da ima povekje lugje so istata najmala vozrast
			List<Person> youngestPersons = people
								.Where(person => person.Age == youngestPersonsAge)
								.ToList();

			Console.WriteLine("---------------------------------------------------");
			Console.WriteLine("List of youngest people on the initial list (or if it's just one person, info for that person):");
			youngestPersons.ForEach(person => Console.WriteLine($"{person.FirstName} {person.LastName}, aged {person.Age}"));



			// Oldest person/s

			int oldestPersonsAge = people
								.Max(person => person.Age);

			List<Person> oldestPersons = people
								.Where(person => person.Age == oldestPersonsAge)
								.ToList();

			Console.WriteLine("---------------------------------------------------");
			Console.WriteLine("List of oldest people on the initial list (or if it's just one person, info for that person):");
			youngestPersons.ForEach(person => Console.WriteLine($"{person.FirstName} {person.LastName}, aged {person.Age}"));


			// Task 05
			// find all male people aged 45 or more

			List<Person> allMalesAged45OrMore = people
									.Where(person => person.Gender == 'M' && person.Age >= 45)
									.ToList();

			Console.WriteLine("---------------------------------------------------");
			Console.WriteLine("List of all male people aged 45 or more:");
			allMalesAged45OrMore.ForEach(person => Console.WriteLine($"{person.FirstName} {person.LastName}, aged {person.Age}"));


			// Task 06
			// find all females whose name starts with V

			List<Person> allFemalesWhoseNameStartsWithV = people
											.Where(person => person.Gender == 'F' && person.FirstName.StartsWith("V"))
											.ToList();

			Console.WriteLine("---------------------------------------------------");
			Console.WriteLine("List of all females whose name starts with a V (or if it's just one person, info for that person):");
			allFemalesWhoseNameStartsWithV.ForEach(person => Console.WriteLine($"{person.FirstName} {person.LastName}"));


			// Task 07
			// find last female person older than 30 whose name starts with P

			Person lastFemaleOlderThan30NameStartsWithP = people
												.Where(person => person.Gender == 'F' && person.Age > 30 && person.FirstName.StartsWith("P"))
												.LastOrDefault();

			Console.WriteLine("---------------------------------------------------");
			Console.WriteLine(lastFemaleOlderThan30NameStartsWithP != null ? $"The last female person older than 30 whose name starts with P is {lastFemaleOlderThan30NameStartsWithP.FirstName} {lastFemaleOlderThan30NameStartsWithP.LastName}." : "There is no female person older than 30 whose name starts with a P.");


			// Task 08
			// find first male younger than 40

			Person firstMaleYoungerThan40 = people
										.Where(person => person.Gender == 'M' && person.Age < 40)
										.FirstOrDefault();

			Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(firstMaleYoungerThan40 != null ? $"The first male person younger than 40 is {firstMaleYoungerThan40.FirstName} {firstMaleYoungerThan40.LastName}." : "There is no male person younger than 40");


			// Task 09
			// print the names of the male persons that have firstName longer than lastName

			List<string> namesOfMalesWithFirstNamesLongerThanLastNames = people
													.Where(person => person.Gender == 'M' && person.FirstName.Length > person.LastName.Length)
													.Select(person => person.FirstName)
													.ToList();

			Console.WriteLine("---------------------------------------------------");
			Console.WriteLine(namesOfMalesWithFirstNamesLongerThanLastNames.Count != 0 ? $"List of the names of all males whose first name is longer than their last name:" : "There are no male persons with first names longer than their last names.");

			if(namesOfMalesWithFirstNamesLongerThanLastNames.Count != 0)
				namesOfMalesWithFirstNamesLongerThanLastNames.ForEach(x => Console.WriteLine(x));


			// Task 10
			// print the lastNames of the female persons that have odd number of ages


			List<string> lastNamesOfFemalesWithOddNumOfAge = people
												.Where(x => x.Gender == 'F' && x.Age % 2 != 0)
												.Select(x => x.LastName)
												.ToList();


			Console.WriteLine("---------------------------------------------------");
			Console.WriteLine(lastNamesOfFemalesWithOddNumOfAge.Count != 0 ? $"List of the last names of the female persons that have odd number of ages:" : "There are no female persons that have odd number of ages.");

			if (lastNamesOfFemalesWithOddNumOfAge.Count != 0)
				lastNamesOfFemalesWithOddNumOfAge.ForEach(x => Console.WriteLine(x));


			Console.ReadLine();
		}
    }
}
