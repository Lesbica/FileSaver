using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSaver.Strategy
{
    interface IFileSavingStrategy
    {
        void Save(string filename, string content);
    }
}
