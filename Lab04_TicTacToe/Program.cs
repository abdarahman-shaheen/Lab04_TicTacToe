using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {

           
            StartGame();

        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            bool flag = true;
            while (flag)
            {
                Player win = PlayGame();
                Console.WriteLine(win.Name);
                Console.WriteLine("play agan ? [y,n]");
                string check= Console.ReadLine();
                if (check == "n")
                {
                    flag = false;
                }
            }
        }
         static Player PlayGame()
        {

            Player player1 = new Player();
            Player player2 = new Player();
            Console.WriteLine("Name  the player 1");
            player1.Name = Console.ReadLine();
            Console.WriteLine("Name the player 2");
            player2.Name = Console.ReadLine();
            player1.Marker = "x";
            player2.Marker = "o";
            player1.IsTurn = true;
            player2.IsTurn = false;
            Game game1 = new Game(player1, player2);
            Player play = game1.Play();
            return play;
        }


    }
}
