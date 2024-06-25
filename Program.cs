using States;
using System.Data;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new AudioPlayer(new Standby());

            while (true)
            {
                Console.WriteLine("Current state: " + player.CurrentState.ToString());
                Console.WriteLine("1 - Play");
                Console.WriteLine("2 - Audio Source");

                string i = Console.ReadLine();
                switch (i)
                {
                    case "1": 
                        player.PressPlay();
                        break;
                        case "2":
                        player.PressAudio();
                        break;

                }

                Console.Clear();
            }

        }
    }
}
