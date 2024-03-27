﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSaver.Strategy
{
    class RtfFileSavingStrategy : IFileSavingStrategy
    {
        public void Save(string filename, string content)
        {
            File.WriteAllText($"{filename}.rtf", content);
            Console.WriteLine($"Saving {filename} as .rtf");
        }
    }
}