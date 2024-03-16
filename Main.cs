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
            ISettingsProvider fileSettingsProvider = new FileSettingsProvider("C:\\guess-the-number\\Config\\settings.txt");
            SettingsLoader settingsLoader = new SettingsLoader(fileSettingsProvider);

            GameSettings settings = settingsLoader.LoadSettings();

            INumberGenerator numberGenerator = new RandomNumberGenerator();
            IUserInterface userInterface = new ConsoleUserInterface();

            Game game = new Game(settings, numberGenerator, userInterface);
            game.PlayGame();
        }
    }
}
