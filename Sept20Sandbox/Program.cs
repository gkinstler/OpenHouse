using System;
using System.Collections.Generic;

namespace Sept20Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!  Welcome to our open house.");

            //I'd like to set up a visible option set for the user, but I'll just use a list for now.//

            List<string> rooms = new List<string>();
            rooms.Add("kitchen");
            rooms.Add("master bedroom");
            rooms.Add("living room");

            Console.WriteLine("What would you like to see first?  The kitchen?  The master bedroom?  The living room?");

            string answer1 = Console.ReadLine();

            if (answer1 == "kitchen" || answer1 == "k")
            {
                Console.WriteLine("Great!  Let's go to the kitchen.");
                rooms.RemoveAt(0);
            }

            if (answer1 == "master bedroom" || answer1 == "master" || answer1 == "m")
            {
                Console.WriteLine("Great!  Let's go to the master bedroom.");
                rooms.RemoveAt(1);
            }

            if (answer1 == "living room" || answer1 == "living" || answer1 == "l")
            {
                Console.WriteLine("Great, let's check out the living room");
                rooms.RemoveAt(2);
            }

            Console.WriteLine($"What would you like to see next? {rooms[0]} or {rooms[1]}?");
            string answer2 = Console.ReadLine();

            if (answer2 == rooms[0])
            {
                Console.WriteLine($"Cool, let's now go to the {rooms[0]}");
                rooms.RemoveAt(0);
            }
            else
            {
                Console.WriteLine($"Cool, let's now go to the {rooms[1]}");
                rooms.RemoveAt(1);
            }

            Console.WriteLine($"OK, we only have the {rooms[0]} left.  Want to see that now?");
            string answer3 = Console.ReadLine();

            if (answer3 == "Yes" || answer3 == "y")
            {
                Console.WriteLine($"Awesome, let's check out {rooms[0]}.");
            }
            else
            {
                //They may want to make an early offer without seeing the last room//

                Console.WriteLine("Do you want to make an offer now on the house?");
                string earlyOffer = Console.ReadLine();

                if (earlyOffer == "Yes" || earlyOffer == "Y")
                {
                    Console.WriteLine("Sweet!  Let's do this!");
                }
                else
                {
                    Console.WriteLine("OK, well good luck!");
                }
            }

            Console.WriteLine("OK, you've now seen everything in the house.  Do you want to make an offer?");
            string offer = Console.ReadLine();

            if (offer == "Yes" || offer == "Y")
            {
                Console.WriteLine("Sweet!  Let's do this!");
            }
            else
            {
                Console.WriteLine("OK, well good luck!");
            }

            Console.ReadLine();
        }
    }
}
