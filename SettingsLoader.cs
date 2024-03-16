using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class SettingsLoader
    {
        private ISettingsProvider _settingsProvider;

        public SettingsLoader(ISettingsProvider settingsProvider)
        {
            _settingsProvider = settingsProvider;
        }

        public GameSettings LoadSettings()
        {
            try
            {
                return _settingsProvider.GetSettings();
            }
            catch (FileNotFoundException)
            {
                _settingsProvider = new ManualSettingsProvider(new ConsoleUserInterface());
                return _settingsProvider.GetSettings();
            }
        }
    }
}
