using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSaver.Strategy
{
    class FileSaverContext
    {
        private IFileSavingStrategy _strategy;

        // Встановлюємо стратегію
        public void SetStrategy(IFileSavingStrategy strategy)
        {
            _strategy = strategy;
        }

        // Використовуємо встановлену стратегію для збереження файлу
        public void SaveFile(string filename, string content)
        {
            if (_strategy == null)
            {
                throw new InvalidOperationException("Strategy is not set.");
            }

            _strategy.Save(filename, content);
        }
    }
}
