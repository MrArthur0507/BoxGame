using GameEntities.Elements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEntities.Elements.Classes
{
    public class Element : IBasicElement
    { 
        public Element() { }
        public Element(char type, int points) { 
            Type = type;
            Points = points;
        }
        public char Type { get; set; }

        public int Points { get; }
    }
}
