namespace HazardAndWhispers.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Game.Game newGame = new();
            newGame.Run();
        }
    }
}