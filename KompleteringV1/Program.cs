using System;
using System.Collections.Generic;

namespace KompleteringV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(); //Create an instance of the player
            while (true)
            {
                Console.Write("Type the number 1 to get out of the vault: ");
                try //Try-Catch to insure the correct answer is written
                {
                    if (int.Parse(Console.ReadLine()) != 1)
                    {
                        Console.WriteLine("You typed the wrong number!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch //If an error occurs
                {
                    Console.WriteLine("You didn't type a number!");
                }
            }
            Console.WriteLine("You got out of the vault!.");
            Console.ReadLine();
            Console.Write("Set your attack and add it to the queue: ");
            player.setAttack(int.Parse(Console.ReadLine())); //Redirects the players answer to the method setAttack
            player.addAttack(player.getAttack()); //Adds the attack to the attack list
            player.QueueAttack(player.getAttack()); //Queues the attack
            player.addAttackSet(player.getAttack()); //Adds the attack to the attack set
            Console.Write("Set a second attack and add it to the queue: ");
            player.setAttack(int.Parse(Console.ReadLine()));
            player.addAttack(player.getAttack());
            player.QueueAttack(player.getAttack());
            player.addAttackSet(player.getAttack());
            Console.WriteLine("This is the list of ur attacks");
            player.ReadAttackList();
            Console.ReadLine();
            Console.WriteLine("The first place in the queue was: " + player.TakeQueue());
            Console.WriteLine("The second place in the queue was: " + player.TakeQueue());
            Console.ReadLine();
            Console.Write("Check what number is in the set: ");
            player.checkAttackSet(int.Parse(Console.ReadLine()));
            Console.ReadLine();

        }
    }
}
