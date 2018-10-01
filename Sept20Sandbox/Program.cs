using System;
using System.Collections.Generic;

namespace Sept20Sandbox
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!  Welcome to our open house.");

            Console.WriteLine("Tell me three rooms that you would like to see.");

            string answer1 = Console.ReadLine();
            RoomsClass room1 = new RoomsClass();
            room1.Name = answer1;

            Console.WriteLine("OK.  What else?");

            string answer2 = Console.ReadLine();
            RoomsClass room2 = new RoomsClass();
            room2.Name = answer2;

            Console.WriteLine("OK, last but not least?");

            string answer3 = Console.ReadLine();
            RoomsClass room3 = new RoomsClass();
            room3.Name = answer3;

            Console.WriteLine($"Great, we'll go see the {room1.Name}, the {room2.Name}, and the {room3.Name}.");


            // I want to create a method to get feedback on each //

            Console.ReadLine();

            // Room 1 //

            //static void AskQuestions(Rooms);
            //{
            //    foreach (RoomsClass room in Rooms)
            //    {
            //        Console.WriteLine($"What do you think about the lighting in {room.Name}?");
            //        room.GoodLighting = Console.ReadLine();

            //        Console.WriteLine($"What do you think about the paint in {room.Name}?");
            //        room.NicePaint = Console.ReadLine();

            //        Console.WriteLine($"What do you think about the size of {room.Name}?");
            //        room.RightSize = Console.ReadLine();
            //    }
            //}

            Console.WriteLine($"What do you think about the lighting in {room1.Name}?");
            room1.GoodLighting = Console.ReadLine();

            Console.WriteLine($"What do you think about the paint in {room1.Name}?");
            room1.NicePaint = Console.ReadLine();

            Console.WriteLine($"What do you think about the size of {room1.Name}?");
            room1.RightSize = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"OK, let's move on to the {room2.Name}.");


            // Room 2 //
            Console.WriteLine($"What do you think about the lighting in {room2.Name}?");
            room2.GoodLighting = Console.ReadLine();

            Console.WriteLine($"What do you think about the paint in {room2.Name}?");
            room2.NicePaint = Console.ReadLine();

            Console.WriteLine($"What do you think about the size of {room2.Name}?");
            room2.RightSize = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"OK, let's move on to the {room3.Name}.");


            // Room 3 //
            Console.WriteLine($"What do you think about the lighting in {room3.Name}?");
            room3.GoodLighting = Console.ReadLine();

            Console.WriteLine($"What do you think about the paint in {room3.Name}?");
            room3.NicePaint = Console.ReadLine();

            Console.WriteLine($"What do you think about the size of {room3.Name}?");
            room3.RightSize = Console.ReadLine();
            Console.WriteLine();


            // Could create a list of the rooms //

            // Recap //

            Console.WriteLine($"Let's recap.  We first went to the {room1.Name}.  \n" +
                $"You thought the lighting was {room1.GoodLighting}.  \n" +
                $"You thought the paint was {room1.NicePaint}.  \n" +
                $"And you thought the size was {room1.RightSize}.");
            Console.WriteLine();


            Console.WriteLine($"Next, we went to the {room2.Name}.  \n" +
                $"You thought the lighting was {room2.GoodLighting}.  \n" +
                $"You thought the paint was {room2.NicePaint}.  \n" +
                $"And you thought the size was {room2.RightSize}.");
            Console.WriteLine();


            Console.WriteLine($"Finally, we went to the {room3.Name}.  \n" +
                $"You thought the lighting was {room3.GoodLighting}.  \n" +
                $"You thought the paint was {room3.NicePaint}.  \n" +
                $"And you thought the size was {room3.RightSize}.");
            Console.WriteLine();


            Console.WriteLine("So what do you think about the house?  Would you like to make an offer?");

            Console.ReadLine();

        }
    }
}
