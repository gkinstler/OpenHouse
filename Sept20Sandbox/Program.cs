using System;
using System.Collections.Generic;

namespace Sept20Sandbox
{
    class Program
    {

        static void Main()
            {
            Console.WriteLine("Hello!  Welcome to our open house.");

            Console.WriteLine("Tell me three rooms that you would like to see.");

            string answer1 = Console.ReadLine();
            Rooms room1 = new Rooms();
            room1.Name = answer1;

            Console.WriteLine("OK.  What else?");

            string answer2 = Console.ReadLine();
            Rooms room2 = new Rooms();
            room2.Name = answer2;

            Console.WriteLine("OK, and last?");

            string answer3 = Console.ReadLine();
            Rooms room3 = new Rooms();
            room3.Name = answer3;

            Console.WriteLine($"Great, we'll go see the {room1.Name}, the {room2.Name}, and the {room3.Name}.");



            public static void RoomReview();

            Console.ReadLine();



        }
    }
}
