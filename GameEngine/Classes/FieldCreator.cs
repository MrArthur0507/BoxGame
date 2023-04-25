
using GameEngine.Classes;
using GameEngine.Interfaces;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GameServices.Classes
{
    public class FieldCreator : IFieldCreator
    {
        private  IField _field;
        private readonly IRowCreator _rowCreator;
        private readonly INumberGetter _numberGetter;

        public FieldCreator(IField field, IRowCreator rowCreator, INumberGetter numberGetter)
        {
            _field = field;
            _rowCreator = rowCreator;
            _numberGetter = numberGetter;
        }

        public  IField CreateField(int cap)
        {
           for (int i = 0; i < cap; i++)
            {
                _field.rows.Add(_rowCreator.CreateRow(cap));
            }
            int row = _numberGetter.GetNumber(cap);
            int column = _numberGetter.GetNumber(cap);

            _field.rows[row].elements[column] = '0';

           return _field; 
        }

    }
}
