using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public interface INumberGenerator
    {
        int GenerateNumber(int min, int max);
    }
    public class RandomNumberGenerator : INumberGenerator
    {
        public int GenerateNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }
}
