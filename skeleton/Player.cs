namespace Skeleton
{
    public class Player: User
    {
        public int color;
        public int timespent;

        // actions
        public bool Move(object cell1, object cell2)
        {
            return true;
        }
    }
}