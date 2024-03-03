using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            SettingsLoader settingsLoader = new SettingsLoader();
            GameSettings settings = settingsLoader.LoadSettingsFromFile("C:\\Users\\Алексей\\source\\repos\\ConsoleApp11\\Config\\settings.txt");

            INumberGenerator numberGenerator = new RandomNumberGenerator();
            IUserInterface userInterface = new ConsoleUserInterface();

            Game game = new Game(settings, numberGenerator, userInterface);
            game.PlayGame();
        }
    }
}
