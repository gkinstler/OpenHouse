using System;
using System.Collections.Generic;

namespace Sept20Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!  Welcome to our open house.");

            List<string> rooms = new List<string>();
            rooms.Add("kitchen");
            rooms.Add("master bedroom");
            rooms.Add("living room");

            Console.WriteLine("What would you like to see first?  The kitchen?  The master bedroom?  The living room?");
        
            while (rooms.Count > 0)
            {
                string answer = Console.ReadLine();

                foreach (string room in rooms)
                {
                    if (room == answer)
                    {
                        Console.WriteLine($"Great!  Let's to go {room}.\n");
                        rooms.Remove(room);
                    }

                    Console.WriteLine("Which room would you like to see next?");
                }
            }


            
            
            Console.ReadLine();



               



        }
    }
}
