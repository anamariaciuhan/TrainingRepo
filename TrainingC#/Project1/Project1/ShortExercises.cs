using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class ShortExercises
    {
        // Write a program that greets the user using the appropriate greeting for the time of day. Use only if, not else or switch, statements to do so

        public static void Greetings()
        {


            DateTime currentime = DateTime.Now;
            var hour = currentime.Hour;

            if (hour >= 00 && hour <= 12)

                Console.WriteLine("Good morning");

            if ((hour > 12) && (hour <= 18))

                Console.WriteLine("Good afernoon");

            if ((hour > 18) && (hour <= 20))

                Console.WriteLine("Good evening");

            if (hour >= 20 && hour <= 00)

                Console.WriteLine("Good night");

            Console.WriteLine(currentime);

                    }

        // Write a program that generates a random number between 1 and 3 and asks the user to guess what the number is.
        //Tell the user if they guess low, high, or get the correct answer. Also, tell the user if their answer is outside of the range of numbers that are valid guesses 
        //(less than 1 or more than 3)
        
        public static void GuessNumber()
        {

              int number = new Random().Next(1,3);
              Console.WriteLine("Guess the number 1:3 : ");
              int yournumber = int.Parse(Console.ReadLine());

             if(yournumber==number)

                Console.WriteLine("Correct");

            else if(yournumber<number)

                Console.WriteLine("Too Low");

             else if(yournumber>number)

                Console.WriteLine("Too high");

            else if(yournumber<1&&yournumber>3)
                Console.WriteLine("Out of range");

            Console.WriteLine("The number was: "+number);

        }

        //  lists all of the factors of the number the user supplies. 

        public static void Factors()
        {
            
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Factors: ");
            while (number > 1)
            {
                int candidateFactor = 2;
                while (candidateFactor <= number)
                {
                    if (number % candidateFactor == 0)
                    {
                        Console.Write(candidateFactor);
                        number = number / candidateFactor;
              
                        if (number > 1)
                            Console.WriteLine(",");
                    }
                    candidateFactor++;
                }
            }
            Console.WriteLine(); 

        }

        //exercitiul for loop : Write a program that prints the result of counting up to 24 using four different increments. First, count by 1s, then by 2s, by 3s, and finally by 4s.

        public static void ForLoop()
        {
            
            for (int i = 1; i <= 4; i++)
            {

                for (int j = 0; j <= 24; j += i)
                {
                    string rezultat = (j).ToString();

                    Console.Write(rezultat.PadLeft(3));
                }

                Console.WriteLine();
            }

      }

        //while ex: Write a program that initializes a list integer numbers, and then prints the numbers out along with their sum.
          
        public static void WhileExercise()
        {

            List<int> myList = new List<int>() { 2, 4, 6 };
            int item = 0;
            int sum = 0;

            while (item < myList.Count)
            {
                sum = sum + myList[item];

                item++;
            }
            Console.Write("Numbers:");
            Console.WriteLine(string.Join(",", myList));
            Console.WriteLine("Sum: " + sum);
        }

        //foreach loop ex: Write a program that initializes a list integer numbers, and then prints the numbers out along with their sum.


        public static void ForEachExercise()
        {


            List<int> anotherList = new List<int>() { 1, 2, 3 };
            int suma = 0;
            foreach (var no in anotherList)
            {
                suma += no;
                Console.Write(no.ToString() + " ,");
            }

       }

        public void DisplayAdress()
        {

             
        }


    }
}
