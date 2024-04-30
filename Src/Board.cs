using System.Drawing;

namespace Chess
{
    public class Board
    {
        public Cell[,] cells;

        public Board()
        {
            cells = new Cell[8,8];
        }

        public void Init()
        {
            for (int i=0; i<8; i++)
            {
                for (int j=0; j<8; j++)
                {
                    cells[i,j] = new Cell(null, i, j);
                }
            }
            for (int j =0; j<8; j++)
            {
                cells[1,j] = new Cell(new Pawn(Color.White), 1, j);
            }
            for (int j =0; j<8; j++)
            {
                cells[6,j] = new Cell(new Pawn(Color.Black), 6, j);
            }

            
        }

        public void PrintBoard()
        {
            Console.WriteLine("Print chess board state");

            for (int i = 0; i<8; i++)
            {
                Console.Write($"{i} ");
                for (int j=0; j<8; j++)
                {
                    if (cells[i,j].piece == null)
                    {
                        Console.Write("    Empty      ");
                    }
                    else
                    {
                        var p = cells[i,j].piece;
                        Console.Write($"   {p.Color.Name}-{p.Name}   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}