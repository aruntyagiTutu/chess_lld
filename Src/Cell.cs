namespace Chess
{
    public class Cell
    {
        public Piece piece;
        public int row;
        public int col;

        public Cell(Piece p, int x, int y)
        {
            piece = p;
            row = x;
            col = y;
        }
    }
}