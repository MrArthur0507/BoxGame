using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Classes
{
    public class Msg : IMsg
    {
        public void Print(string input)
        {
            Console.WriteLine(input);
        }
    }
}
