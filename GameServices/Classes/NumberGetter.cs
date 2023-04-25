using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Classes
{
    public class NumberGetter : INumberGetter
    {
        private readonly Random _random;

        public NumberGetter(Random random)
        {
            _random = random;
        }
      
        public int GetNumber(int cap)
        {
            int result = _random.Next(cap);
            return result;
        }
    }
}
