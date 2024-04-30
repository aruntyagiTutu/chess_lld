using System.Drawing;

namespace Chess
{
    public class Player: User
    {
        public Color color;
        public int timespent;
        public Player(Color color, int Id, string name): base(name)
        {
            this.color = color;
            this.Id = Id;
        }
        // actions
        public bool Move(Cell from, Cell to)
        {
            // if there is no piece in source cell
            if (from == null || from.piece == null) 
            {
                Console.WriteLine("Noting in source cell");

                return false;
            }

            Piece p = from.piece;
            // if player trying to move opponents 
            if (p.Color != color) 
            {
                Console.WriteLine("Not your color in source");
                return false;
            }

            // if destination contains same players piece
            if (to != null && to.piece != null && to.piece.Color == color) 
            {
                Console.WriteLine("Destination contains your piece");
                return false;
            }

            // if not valid move for the piece
            if ( !p.IsValidMove(from, to) ) 
            {
                Console.WriteLine("Not valid move for this piece");
                return false;
            }

            // kill opponent piece
            if (to.piece != null)
            {
                to.piece.InGame = false;
                to.piece = null;
            }

            to.piece = from.piece;
            from.piece = null;
            return true;
        }

        public bool CanMove()
        {
            return true;
        }
    }
}