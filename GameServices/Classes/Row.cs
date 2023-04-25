using GameEntities.Elements.Interfaces;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Classes
{
    public class Row : IRow
    {
        public List<char> elements { get; set; } = new List<char>();
    }
}
