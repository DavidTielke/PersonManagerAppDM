using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClient
{
    public class FileReader
    {
        public IEnumerable<string> ReadAllLines(string path)
        {
            var lines = File.ReadAllLines(path);
            return lines;
        }
    }
}