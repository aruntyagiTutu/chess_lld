namespace Chess
{

    public class User
    {
        public int Id;
        public string Name;
        public int Level;
        public User(string name)
        {
            this.Name = name;
            Id = int.MaxValue;
        }
        // Actions
        public void GameRequest()
        {
            
        }
    }
}