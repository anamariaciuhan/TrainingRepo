using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class MethodsLesson
    {

        //methods
        //In lesson 10 you wrote a program to manage a list of items, responding to different commands the user typed. Use what you've learned about methods
        //to break up that program into several methods, each responsible for a different part of the program.


        static List<string> ShoppingList = new List<string>();

       

        public static void AddItem(string userInput)
        {
            ShoppingList.Add(userInput.Substring(2));
            Console.WriteLine(String.Join((" ,"), ShoppingList));

        }

        static void RemoveItem(string userInput)
        {
            ShoppingList.Remove(userInput.Substring(2));
            Console.WriteLine(String.Join((" ,"), ShoppingList));
        }

        static void ClearList()
        {
            ShoppingList.Clear();
        }

    
        
         public static string ItemAction(string userInput)
        {
            if (userInput == "--")
            {
                ClearList();
     
            }
           
            else if (userInput[0] == '+')

                AddItem(userInput);

            else if (userInput[0] == '-')

                RemoveItem(userInput);


            return $"{ShoppingList}";

        } }


    }


