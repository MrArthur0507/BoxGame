using GameEntities.Elements.Classes;
using GameEntities.Elements.Interfaces;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Classes
{
    public class SymbolGetter : ISymbolGetter
    {
        private readonly INumberGetter _numberGetter;

        private readonly ISymbolStorage _symbolStorage;

        public SymbolGetter(INumberGetter numberGetter, ISymbolStorage storage)
        {
            _numberGetter = numberGetter;
            _symbolStorage = storage;
        }

        public char Get()
        {
            int index = _numberGetter.GetNumber(_symbolStorage.symbols.Count);

            return _symbolStorage.symbols[index].Type;
        }
    }
}
