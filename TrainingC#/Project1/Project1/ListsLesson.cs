using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class ListsLesson
    {

        /* exercitiu lists
            Write a simple program that lets the user manage a list of elements. It can be a grocery list, "to do" list, etc.
            Each time through the loop, ask the user to perform an operation, and then show the current contents of their list. The operations available should be Add, Remove, and Clear. The syntax should be as follows:
             +some item
           - some item
            -- */

        public static void ToDoList()
        {

            List<string> ToDo = new List<string>();
         //   bool flag = true;

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");

                string command = Console.ReadLine();

                   if (command == "--")

                {
                    ToDo.Clear();
                    break;

                }

               else if (command[0] == '+')

                {
                    ToDo.Add(command.Substring(2));
                    Console.WriteLine(String.Join(",", ToDo));
                }

                else if (command[0] == '-')
                {
                    ToDo.Remove(command.Substring(2));
                    Console.WriteLine(String.Join(",", ToDo));
                }

   

            }
    }
    }
}
