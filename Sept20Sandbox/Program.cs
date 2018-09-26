using System;
using System.Collections.Generic;

namespace Sept20Sandbox
{
    class Program
    {
        public static Rooms ChooseRoom()
        {
            Console.WriteLine("Which room would you like to see?");
            string answer1 = Console.ReadLine();
            Rooms room1 = new Rooms();
            room1.Name = answer1;
            return room1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!  Welcome to our open house.");

            Rooms chosenRoom = ChooseRoom();

            Console.ReadLine();

            //return a room to the method.  

               



        }
    }
}
