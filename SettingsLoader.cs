using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class SettingsLoader
    {
        public GameSettings LoadSettingsFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            int minNumber = 0, maxNumber = 0, maxAttempts = 0;

            foreach (var line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    switch (parts[0])
                    {
                        case "MinNumber":
                            int.TryParse(parts[1], out minNumber);
                            break;
                        case "MaxNumber":
                            int.TryParse(parts[1], out maxNumber);
                            break;
                        case "MaxAttempts":
                            int.TryParse(parts[1], out maxAttempts);
                            break;
                    }
                }
            }

            return new GameSettings { MinNumber = minNumber, MaxNumber = maxNumber, MaxAttempts = maxAttempts };
        }
    }
}
