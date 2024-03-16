using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class ManualSettingsProvider : BaseSettingsProvider
    {
        private readonly IUserInterface _userInterface;

        public ManualSettingsProvider(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        public override GameSettings GetSettings()
        {
            _userInterface.DisplayMessage("Настройки не найдены. Проверьте расположение файла setting.txt. Он должен находится по пути: Папка программы\\Config\\setting.txt Предлагаю ввести настройки вручную");
            int minNumber = _userInterface.ReadIntInput("Введите минимальное число в диапазоне чисел, которые нужно угадать: ");
            int maxNumber = _userInterface.ReadIntInput("Введите максимальное число в диапазоне чисел, которые нужно угадать: ");
            int maxAttempts = _userInterface.ReadIntInput("Введите количество попыток: ");

            GameSettings gameSettings = new GameSettings { MinNumber = minNumber, MaxNumber = maxNumber, MaxAttempts = maxAttempts };

            return gameSettings;
        }
    }

}
