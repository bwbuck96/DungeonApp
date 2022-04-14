using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DUNGEON OF DOOM!";

            Console.WriteLine("Your journey begins...\n");
            // 1 Create a Player & a Weapon

            Weapon sword = new Weapon("Falchion", false, 1, 5, 10);
            Player playerOne = new Player("Garbok", 5, 30, 100, 100, Race.Tiefling, sword);
            //TODO Remember how to specifically call 

            //2. Create a Loop for the game

            bool exit = false;

            do
            {
                //3. Create a room - making a method to generate a room description.
                Console.WriteLine("You have now entered a room...\n");
                Console.WriteLine(GetRoom());

                //TODO 4. Create a Monster

                //5. Create a Loop for the Menu
                bool reload = false;
                do
                {
                    //6. Provide the User with a Menu of Options
                    Console.WriteLine("\nPlease choose an action\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "W) Weapon Stats\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    //7. Catch the user's choice
                    //string userChoice = Console.ReadLine().ToUpper(); ---OPTION 1
                    ConsoleKey userChoice = Console.ReadKey(true).Key; // -----OPTION 2

                    Console.Clear();

                    //8. Build out a switch to handle the user's choice.
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //TODO 9 Handle the combat logic & what happens if the player wins
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run Away!!!");
                            //TODO 10 Handle the user running away & the monster getting a free attack
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Info: ");
                            // 11 Print out Player info
                            Console.WriteLine(playerOne);
                            break;
                        case ConsoleKey.W:
                            Console.WriteLine(sword);
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster Info: ");
                            //TODO 12 Print out Monster info
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("Nobody likes a quitter! Boo!");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Thou hast chosen an improper option. Triest though again.");
                            break;
                    }

                    //TODO 13 Check the Player's life (health)

                } while (!exit && !reload); //While exit AND reload are false, keep running

            } while (!exit);//While exit is false, keep running

            //TODO 14 State the Player's Score (How many monsters were killed?)
        }
        private static string GetRoom()
        {
            string[] rooms =  {
                "The room is dark and musty with the smell of lost souls.",
                "You enter a pretty pink powder room and instantly get glitter on you.",
                "You arrive in a room filled with chairs and a ticket stub machine...DMV",
                "You enter a quiet library... silence... nothing but silence....",
                "As you enter the room, you realize you are standing on a platform surrounded by sharks",
                "Oh my.... what is that smell? You appear to be standing in a compost pile",
                "You enter a dark room and all you can hear is hair band music blaring.... This is going to be bad!",
                "Oh no.... the worst of them all... Oprah's bedroom....",
                "The room looks just like the room you are sitting in right now... or does it?",
            };

            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;

        }
    }
}
