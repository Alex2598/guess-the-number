using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public interface IUserInterface
    {
        void DisplayMessage(string message);
        string GetUserInput();
    }

    public class ConsoleUserInterface : IUserInterface
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string GetUserInput()
        {
            return Console.ReadLine();
        }
    }
}
