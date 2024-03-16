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
        int ReadIntInput(string message);
    }

 
}
