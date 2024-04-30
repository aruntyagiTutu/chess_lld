using System.Drawing;

namespace Chess
{
    public class Game
    {
        public int ID;
        Board board;
        Player WhitePlayer;
        Player BlackPlayer;
        Player turnPlayer;

        public Game(User u1, User u2)
        {
            WhitePlayer = new Player(Color.White, u1.Id, u1.Name);
            BlackPlayer = new Player(Color.Black, u2.Id, u2.Name);
            board = new Board();
            turnPlayer = WhitePlayer;
        }

        private (Cell, Cell) MovementInput()
        {
            var line1 = Console.ReadLine();
            if(line1.Contains("exit")){
                return (null, null);
            }
            int[] x1y1 = line1.Split(' ').Select(int.Parse).ToArray();
            int[] x2y2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Cell from = board.cells[x1y1[0], x1y1[1]];
            Cell to = board.cells[x2y2[0], x2y2[1]];
            return (from, to);
        }
        public Player Start()
        {
            board.Init();
            while (true)
            {
                board.PrintBoard();
                Console.WriteLine($"{turnPlayer.color} turn");

                var input = MovementInput();
                if (input.Item1 == null)
                {
                    return null;
                }
                Cell from = input.Item1;
                Cell to = input.Item2;

                while (!turnPlayer.Move(from, to))
                {
                    Console.WriteLine("This is not a valid move, Provide valid move...");


                     input = MovementInput();
                     if (input.Item1 == null)
                    {
                        return null;
                    }
                    from = input.Item1;
                    to = input.Item2;
                }

                turnPlayer = (turnPlayer.color == Color.Black) ? WhitePlayer : BlackPlayer;


                if (!turnPlayer.CanMove())
                {
                    Player winner = turnPlayer.color == Color.Black ? WhitePlayer : BlackPlayer;
                    return winner;
                }
            }
        }
    }
}