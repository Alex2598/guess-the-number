using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class ConsoleUserInterface : IUserInterface
    {
        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public int ReadIntInput(string message)
        {
            DisplayMessage(message); 
            while (true)
            {
                string input = GetUserInput();
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    DisplayMessage("Введите корректное число.");
                }
            }
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
