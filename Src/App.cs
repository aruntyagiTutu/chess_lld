using System;
using System.Diagnostics;
namespace Chess
{
    public class App
    {
        public static App Instance;
        public static App GetApp()
        {
            if (Instance == null)
            {
                Instance = new App();
            }
            return Instance;
        }


        private App()
        {
            games = new List<Game>();
            users = new List<User>();
            waitingList = new List<User>();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Chess Game!");

            while (true)
            {
                Console.WriteLine("Type 'start game' to begin a new game...");

                string userInput = Console.ReadLine();

                if (userInput.Equals("start game", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Starting... type exit anytime to exit the game");
                    StartNewGame();
                }
                else
                {
                    Console.WriteLine("Invalid command. Please try again.");
                }
            }
        }

        static void StartNewGame()
        {
            Console.WriteLine("Starting a new game...");
           
            CreateGame();
        }
        public int Id;

        public List<User> waitingList;
        public List<Game> games;
        public List<User> users;
        // Actions

        private static Game CreateGame()
        {
            Console.WriteLine("Enter user names");
            var user1 = Console.ReadLine();
            var user2 = Console.ReadLine();

            var whitePlayer = new User(user1);
            var blackPlayer = new User(user2);

            var game = new Game(whitePlayer, blackPlayer);
            var winner = game.Start();
            if(winner == null){
                Console.WriteLine($"Player existed from the game");
                return game;    
            }
            Console.WriteLine($"Winner is {winner.Name}");
            return game;
        }
    }
}