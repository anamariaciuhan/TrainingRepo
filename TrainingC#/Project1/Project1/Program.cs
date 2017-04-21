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
            var people = Linq.GenerateListOfPeople();

            IEnumerable<FullName> allFullNames = people.Select(x => new FullName { First = x.FirstName, Last = x.LastName });
            
            var allFirstNames = allFullNames.Select(y => y.First).ToList();

            var lastOrDefault = people.LastOrDefault();
            var firstOrDefacult = people.FirstOrDefault();
            var first24YearsOld = people.FirstOrDefault(a => a.Age == 24); // sau var 2: first24YearsOld=people.Where(a => a.Age ==24).FirstOrDefault();
            var singleorDefault = people.SingleOrDefault(b => b.FirstName == "Samantha");
            int countPeople24YearsOld = people.Count(a => a.Age == 24);
            bool checkList = people.Any();

            var devsOlderThan24 = people.Where(x => x.Occupation == "Dev" && x.Age > 24).ToList();


            foreach (var fullName in allFullNames)
            {
                Console.WriteLine($"{fullName.Last}, {fullName.First}");
            }

            Console.WriteLine();
            foreach(var firstname in allFirstNames)
            {
                Console.WriteLine(firstname);
            }

            Console.WriteLine(Environment.NewLine+lastOrDefault);
            Console.WriteLine(Environment.NewLine+firstOrDefacult);
            Console.WriteLine(first24YearsOld.FirstName);
            Console.WriteLine("SingleOrDefault result: "+singleorDefault);
            Console.WriteLine(Environment.NewLine+countPeople24YearsOld+" people are 24 years old");
            Console.WriteLine(Environment.NewLine+checkList+" the list is populated ");

            foreach (var dev in devsOlderThan24)
            {
                Console.WriteLine(Environment.NewLine + dev);

            }

            Console.WriteLine();
            var customer1 = new Customer() { Name = "Vlad" };
            customer1.AddOrder(new Order("123", new DateTime(2007, 2, 3)));
            customer1.AddOrder(new Order("234", new DateTime(2007, 3, 6)));
            customer1.AddOrder(new Order("345", new DateTime(2007, 4, 5)));

            var customer2 = new Customer() { Name = "Mihai" };
            customer2.AddOrder(new Order(null, new DateTime(2007, 2, 3)));
            customer2.AddOrder(new Order("200", new DateTime(2007,7,3)));
            customer2.AddOrder(new Order("300", new DateTime(2007, 8, 9)));
            customer2.AddOrder(new Order("300", new DateTime(2007, 10, 9)));


            var customerList = new List<Customer>();
            customerList.Add(customer1);
            customerList.Add(customer2);

           foreach(var customer in customerList)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine("Orders: ");

                foreach(var order in customer.GetCustomerOrders() )
                {

                    Console.WriteLine(order);
                    
                }
            }

            Console.WriteLine($"Customer 1 Order Count: {customer1.Orders.Count}");
            Console.WriteLine($"Customer 2 Order Count: {customer2.Orders.Count}");


            Console.WriteLine();
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


            var student1 = new Student("Ana", "Ciuhan", new DateTime(1994, 11, 29));
            var student2 = new Student("Maria", "Ciuhan", new DateTime(1993, 11, 24));
            var student3 = new Student("Ion", "Ionescu", new DateTime(1992, 12, 25));

            var curs1 = new Course("info");

           // curs1.CourseName = "info";
            curs1.AddStudentToCourse(student1);
            curs1.AddStudentToCourse(student2);
            curs1.AddStudentToCourse(student3);

            foreach(var studentName in curs1.GetStudentsNames())
            {
                Console.WriteLine(studentName);
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
     
  
    



    
