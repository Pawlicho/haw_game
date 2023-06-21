namespace HazardAndWhispers.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game.Game newGame = new();

            while(newGame.IsRunning) 
            {
                /* Print help for the user */
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(newGame.GetHelpInstructions());
                Console.ResetColor();

                /* Wait for the keybord input and clear CLI */
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.Clear();

                /* Execute Action */
                string output = newGame.Action(keyInfo.Key);

                /* And Print the output */
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(output);
                Console.ResetColor();
            }
            
        }
    }
}