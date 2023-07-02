namespace HazardAndWhispers.App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game.Game newGame = new();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(newGame.WelcomeMsg);
            Console.ResetColor();

            Thread.Sleep(3000);

            while (newGame.IsRunning) 
            {
                /* Print help for the user */
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(newGame.GetHelpInstructions());
                Console.ResetColor();

                /* Wait for the keybord input and clear CLI */
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.Clear();

                /* Execute Action */
                string output = newGame.Action(keyInfo);

                /* And Print the output */
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(output);
                Console.ResetColor();

                if (!(newGame.EvalGame()))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(newGame.FarewellMsg);
                    Console.ResetColor();
                    newGame.Finish();
                }
            }

            Thread.Sleep(3000);

        }
    }
}