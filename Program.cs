using System;
namespace Linq
{
    class Program
    {
        class famousPeople
        {
            public string Name { get; set; }
            public int? BirthYear { get; set; } = null;
            public int? DeathYear { get; set; } = null;
        }
        static void Main(string[] args)
        {        
            IList<famousPeople> stemPeople = new List<famousPeople>() {
            new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
            new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
            new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
            new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
            new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
            new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
            new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
            new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
            new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
            new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
            new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
            new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
            new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
            new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
            new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
            new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
         };
            // LINQ query syntax

            // a) Retrieve people with birthdates after 1900
            var result = from s in stemPeople
                         where s.BirthYear > 1900
                         select s;
            Console.WriteLine("People with birthdates after 1900:");
            foreach (var person in  result)
            {
                Console.WriteLine(person.Name);
            }

            //b) Retrieve people who have two lowercase L's in their name
            result = from s in stemPeople
                     where s.Name.Contains("ll")
                     select s;
            Console.WriteLine("\nPeople who have two lowercase L's in their name");
            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }

            //c) Count the number of people with birthdays after 1950
            result = from s in stemPeople
                     where s.BirthYear > 1950
                     select s;
            Console.WriteLine($"\nNumber of people with birthdays after 1950: {result.Count()}");

            //d) Retrieve people with birth years between 1920 and 2000.
            //Display their names and count the number of people in the list, then display the count.
            result = from s in stemPeople
                     where s.BirthYear >1920 && s.BirthYear<2000
                     select s;
            Console.WriteLine("\nPeople with birth years between 1920 and 2000");
            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine($"Total people: {result.Count()}");

            //e) Sort the list by BirthYear
            result = from s in stemPeople
                     orderby s.BirthYear
                     select s;
            Console.WriteLine("\nSorted by birth year");
            foreach(var person in result)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.BirthYear);
            }

            //f) Retrieve people with a death year after 1960 and before 2015,
            //sort the list by name in ascending order.
            result = from s in stemPeople
                     where s.DeathYear > 1960 && s.DeathYear<2015
                     orderby s.Name
                     select s;
            Console.WriteLine("\nPeople with a death year after 1960 and before 2015, sorted by name in ascending order.");
            foreach( var person in result)
            {
                Console.WriteLine(person.Name);
            }


        }
    }
}
