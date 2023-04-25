using GameEntities.Elements.Interfaces;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Classes
{
    public class SymbolStorage : ISymbolStorage
    {
        public List<IBasicElement> symbols { get; set; } = new List<IBasicElement>();

        public void AddSymbol(IBasicElement symbol)
        {
            symbols.Add(symbol);
        }
    }
}
