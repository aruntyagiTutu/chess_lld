
using System.Drawing;

namespace Chess
{
    public abstract class Piece
    {
        public Color Color;
        public bool InGame;
        public abstract bool IsValidMove(Cell from, Cell to);
        public string Name;
        public string ShortName;
    }
}