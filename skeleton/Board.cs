namespace Chess
{
    public class Board
    {
        public Cell[,] cells;

        public Board()
        {
            cells = new Cell[8,8];
        }
    }
}