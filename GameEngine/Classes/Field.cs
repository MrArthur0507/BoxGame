using GameEntities.Elements.Interfaces;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Classes
{
    public class Field : IField
    {
        public List<IRow> rows { get; set; } = new List<IRow>();
    }
}
