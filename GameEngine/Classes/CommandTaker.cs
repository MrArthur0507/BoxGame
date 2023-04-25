using GameEngine.Interfaces;
using GameEngine.Services;
using GameEntities.PlayerData.Classes;
using GameServices.Classes;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Classes
{
    public class CommandTaker : ICommandTaker
    {
        private readonly ITextService _textService;
        private readonly IStorage _storage;
        private readonly ISymbolStorage _symbolStorage;
        public CommandTaker(IStorage storage, ITextService textService, ISymbolStorage symbolStorage)
        {
            _textService = textService;
            _storage = storage;
            _symbolStorage = symbolStorage;
        }
        public void TakeCommand(string input, int playerId)
        {
            string[] commands = input.Split(" ");
            int row = Int32.Parse(commands[0]);
            int column = Int32.Parse(commands[1]);
            ExecuteCommand(row,column, playerId);
        }

        public void ExecuteCommand(int row, int column, int playerId)
        {
            if (_storage.Field.rows[row - 1].elements[column - 1] == '0')
            {
                _storage.ZeroFound = true;
            }
            if (_storage.Moves.Any(x => x.Row == row && x.Column == column))
            {
                _textService.Write("Box already opened");
            }
            else
            {
                _storage.Moves.Add(new Move(_storage.Players[playerId], row, column));
                char element = _storage.Field.rows[row - 1].elements[column - 1];
                if (_symbolStorage.symbols.Any(x => x.Type == element))
                {
                    _storage.Players[playerId].Points += _symbolStorage.symbols.Find(x => x.Type == element).Points;

                }
                _textService.Write("Opened --> " + "  " + _storage.Field.rows[row - 1].elements[column - 1].ToString());
            }
        }
    }
}
