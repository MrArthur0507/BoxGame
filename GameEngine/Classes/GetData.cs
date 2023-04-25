using GameEngine.Interfaces;
using GameEngine.Services;
using GameEntities.Elements.Classes;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Classes
{
    public class GetData : IGetData
    {
        private readonly ITextService _textService;
        private readonly ISymbolStorage _storage;

        public GetData(ITextService textService, ISymbolStorage storage)  {
            _textService = textService;
            _storage = storage;
        }

        private bool IsNumber(string input, int min, int max)
        {
            int num;
            bool isNum = int.TryParse(input, out num);
            if (!isNum || num > max || num < min)
            {
                return false;
            }
            return true;
        }
        public int GetFieldSize()
        {
            int size;
            while (true)
            {
                
                _textService.Write("Enter field size.Min size is 3 and Max size is 10!");
                _textService.Write("Example --> 3");
                string input = _textService.Read();
                if(IsNumber(input, 3, 10))
                {
                    size = Int32.Parse(input);
                    break;
                } else
                {
                    _textService.Write("Invalid number!");
                }
            }
            return size;
        }

        public int GetPlayerCount()
        {
            _textService.Clear();
            int count;
            while (true)
            {

                _textService.Write("Enter player count. Max count is 6 and Min count is 2!");
                _textService.Write("Example --> 2");
                string input = _textService.Read();
                if (IsNumber(input, 2, 6))
                {
                    count = Int32.Parse(input);
                    break;
                }
                else
                {
                    _textService.Write("Invalid count!");
                }
            }
            return count;
        }

        public int GetSymbolCount()
        {
            _textService.Clear();
            int count;
            while (true)
            {

                _textService.Write("Enter symbol count! Min count is 2 and Max count is 6!");
                _textService.Write("Example --> 3");
                string input = _textService.Read();
                if (IsNumber(input, 2, 6))
                {
                    count = Int32.Parse(input);
                    break;
                }
                else
                {
                    _textService.Write("Invalid count!");
                }
            }
            return count;
        }

        public void GetSymbol(int cap)
        {
            for (int i = 0; i < cap; i++)
            {
                
                while (true)
                {
                    char symbol;
                    int points;
                    _textService.Write("Enter" + " " + (i + 1) + " " + "Symbol, Example *");
                    string input = (_textService.Read());
                    if (input.Length > 1)
                    {
                        _textService.Write("Invalid symbol!");
                        continue;
                    }
                    else
                    {
                        symbol = char.Parse(input);
                    }
                    _textService.Write("Enter points for " + " " + (i + 1) + " " + " Symbol, Min - 1, Max - 40");
                    _textService.Write("Example --> 10");
                    string pointsInput = _textService.Read();
                    if (!IsNumber(pointsInput, 1, 40))
                    {
                        _textService.Write("Invalid points!");
                        continue;
                    } 
                    points = Int32.Parse(pointsInput);
                    if (_storage.symbols.Any(x => x.Type == symbol))
                    {
                        _textService.Write("The symbol already exists!");
                        continue;
                    }
                    else
                    {
                        _storage.symbols.Add(new Element(symbol, points));
                        break;
                    }

                }
            }
        }
    }
}
