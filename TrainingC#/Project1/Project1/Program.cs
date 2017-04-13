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
     
  
    



    
