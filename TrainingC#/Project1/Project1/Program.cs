using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Person> PersonList = new List<Person>();
            var person1 = new Person();
            person1.FirstName = "Ana-Maria";
            person1.LastName = "Ciuhan";
            person1.Address.Street = "Str. G. Alexandrescu ";
            person1.Address.Number = 28;
            person1.Address.City = "Cluj-Napoca";
            person1.Address.Country = "Romania";
            person1.Address.PostalCode = "500160";



            var person2 = new Person();
            person2.FirstName = "Catalin";
            person2.LastName = "Viu";
            person2.Address.Street = "Str. G. Alexandrescu ";
            person2.Address.Number = 28;
            person2.Address.City = "Cluj-Napoca";
            person2.Address.Country = "Romania";
            person2.Address.PostalCode = "500160";

            List<Company> CompanyList = new List<Company>();

            var company1 = new Company();
            company1.Name = "Fortech";
            company1.Address.Street = "Str. Frunzisului";
            company1.Address.Number = 106;
            company1.Address.PostalCode = "100200";
            company1.Address.City = "Cluj-Napoca";
            company1.Address.Country = "Romania";

            PersonList.Add(person1);
            PersonList.Add(person2);
            CompanyList.Add(company1);

            PersonList.ForEach(Console.WriteLine);

            foreach (var item in CompanyList)
            {
                Console.WriteLine(item);
            }

        


            while (true)
            {
                Console.WriteLine("Enter your action: + item to add, - item to delete or -- to clear all");

                string userInput = Console.ReadLine();

                MethodsLesson.ItemAction(userInput);

                if (userInput == "--")
                    break;

            }

            ListsLesson.ToDoList();

            ShortExercises.Greetings();

            ShortExercises.GuessNumber();

            ShortExercises.Factors();

            ShortExercises.ForLoop();
            ShortExercises.ForEachExercise();
            ShortExercises.WhileExercise();

            //  array

            int[] vector = new int[] { 1, 2, 3 };

            int[,] matrice = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            // array from strings example

            string input = "red,blue,yellow,green";
            string[] colors = input.Split(','); // note single quotes, which are used to define literal character (``char``) values

            // Console.WriteLine(colors[0]);
            // Console.WriteLine(colors[1]);

            //Lists

            List<string> product = new List<string>();
            product.Add("mere");
            product.Add("pere");
            product.Add("blablabla");
            product.Insert(3, "banana");

            //  product.RemoveAll(p => p.Contains("a"));
            product.RemoveAt(0);
            int nrproduse = product.Count();

            Console.WriteLine("numarul de produse din lista este " + nrproduse);

            //  product.ForEach(Console.WriteLine); // echivalent cu :

            //   product.ForEach(p => Console.WriteLine(p));

            //Console.WriteLine(product[0]);
            //Console.WriteLine("           ");
            //Console.WriteLine(String.Join(",", product)); // creats a string from a list

            Console.ReadLine();
        }

    }

}
     
  
    



    
