using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSaver.Strategy
{
    class DocFileSavingStrategy : IFileSavingStrategy
    {
        public void Save(string filename, string content)
        {
            File.WriteAllText($"{filename}.doc", content);
            Console.WriteLine($"Saving {filename} as .doc");
        }
    }
}
