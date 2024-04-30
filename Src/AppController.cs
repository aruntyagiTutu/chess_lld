namespace Chess
{
    public class AppController
    {
        App app = App.GetApp();
        public void RequestGame(User user)
        {
            //app.waitingList.Add(user);
            Console.WriteLine("Game requested, please wait");
        }
    }
}