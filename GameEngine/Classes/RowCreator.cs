using GameEngine.Interfaces;
using GameEntities.Elements.Classes;
using GameEntities.Elements.Interfaces;
using GameServices.Classes;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Classes
{
    public class RowCreator : IRowCreator
    {
        private readonly ISymbolGetter _symbolGetter;
        private  IRow _row;
        public RowCreator(ISymbolGetter symbolGetter, IRow row, IBasicElement element)
        {
            _symbolGetter = symbolGetter;
            _row = row;
        }

        public IRow CreateRow(int cap)
        {
            
            for (int i = 0; i < cap; i++)
            {
                _row.elements.Add(_symbolGetter.Get());
            }
            return _row;
        }
    }
}
