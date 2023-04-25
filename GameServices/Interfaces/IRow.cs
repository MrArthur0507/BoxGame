using GameEntities.Elements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Interfaces
{
    public interface IRow
    {
        public List<char> elements { get; set; }
    }
}
