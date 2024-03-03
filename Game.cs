using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Game
    {
        private readonly GameSettings _settings;
        private readonly INumberGenerator _numberGenerator;
        private readonly IUserInterface _userInterface;

        public Game(GameSettings settings, INumberGenerator numberGenerator, IUserInterface userInterface)
        {
            _settings = settings;
            _numberGenerator = numberGenerator;
            _userInterface = userInterface;
        }

        public void PlayGame()
        {
            int targetNumber = _numberGenerator.GenerateNumber(_settings.MinNumber, _settings.MaxNumber);
            int attemptsLeft = _settings.MaxAttempts;

            _userInterface.DisplayMessage($"Угадайте число от {_settings.MinNumber} до {_settings.MaxNumber}");

            while (attemptsLeft > 0)
            {
                _userInterface.DisplayMessage($"У вас осталось {attemptsLeft} попыток. Введите число:");

                string input = _userInterface.GetUserInput();

                if (!int.TryParse(input, out int guess))
                {
                    _userInterface.DisplayMessage("Введите корректное число.");
                    continue;
                }

                if (guess == targetNumber)
                {
                    _userInterface.DisplayMessage("Поздравляем! Вы угадали число!");
                    return;
                }
                else if (guess < targetNumber)
                {
                    _userInterface.DisplayMessage("Загаданное число больше.");
                }
                else
                {
                    _userInterface.DisplayMessage("Загаданное число меньше.");
                }

                attemptsLeft--;
            }

            _userInterface.DisplayMessage($"Игра окончена. Вы не угадали число. Загаданное число было: {targetNumber}");
        }
    }
}
