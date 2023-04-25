using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Classes
{
    public class Reader : IReader
    {
        public string Read()
        {
            string input = Console.ReadLine();

            return input;
        }
    }
}
