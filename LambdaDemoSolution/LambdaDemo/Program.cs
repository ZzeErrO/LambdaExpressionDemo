using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            int sum = 0;
            AddRecords(listPersonInCity);
            Retriving_TopTwoRecord_ForAges_LessThanSixty(listPersonInCity);
            CheckingForTeenagesPerson(listPersonInCity);
            listPersonInCity.ForEach(x => sum+=x.Age);
            Console.WriteLine("Average of Records");
            Console.WriteLine((double)sum/listPersonInCity.Count);
            CheckAName(listPersonInCity);
            Retriving_ForAges_MoreThanSixty(listPersonInCity);
            RemoveAName(listPersonInCity);
            Console.ReadKey();
        }

        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 25));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
            // Console.WriteLine(listPersonInCity.ToString());
            //listPersonInCity.ForEach(x => Console.WriteLine("{0}\t", x.Name.ToString()));
        }

        private static void Retriving_TopTwoRecord_ForAges_LessThanSixty(List<Person> listPersonsInCity)
        {
            Console.WriteLine("Top 2 Records for Person Age less than 60 years");
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: " + person.Name + "\t\tAge: " + person.Age);
            }
        }


        private static void CheckingForTeenagesPerson(List<Person> listPersonsInCity)
        {
            if (listPersonsInCity.Any(e => e.Age >= 13 && e.Age <= 19))
                Console.WriteLine("Yes, we have some teenages in list");
            else
                Console.WriteLine("No, we don't have some teenages in list");

            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age >= 13 && e.Age <= 18)).ToList())
            {
                Console.WriteLine("Name: " + person.Name + "\t\tAge: " + person.Age);
            }

        }

        private static void CheckAName(List<Person> listPersonsInCity)
        {
            Console.WriteLine("Write Name that you want to Check");
            string name_Check = Console.ReadLine();
            if (listPersonsInCity.Any(e => e.Name == name_Check))
                Console.WriteLine("Name is PRESENT in list");
            else
                Console.WriteLine("Name is NOT in list");
        }

        private static void Retriving_ForAges_MoreThanSixty(List<Person> listPersonsInCity)
        {
            Console.WriteLine("Records for Person Age more than 60 years");
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age >= 60)).ToList())
            {
                Console.WriteLine("Name: " + person.Name + "\t\tAge: " + person.Age);
            }
        }

        private static void RemoveAName(List<Person> listPersonsInCity)
        {
            Console.WriteLine("Write Name that you want to Remove ");
            string name_Check = Console.ReadLine();
            try
            {
                var itemToRemove = listPersonsInCity.Single(r => r.Name == name_Check);
                listPersonsInCity.Remove(itemToRemove);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            listPersonsInCity.ForEach(x => Console.WriteLine("{0}\t", x.Name.ToString()));
        }

    }
}
