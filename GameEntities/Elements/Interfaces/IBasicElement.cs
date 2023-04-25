using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEntities.Elements.Interfaces
{
    public interface IBasicElement
    {
        public char Type { get; set; }

        public int Points { get; }
    }
}
