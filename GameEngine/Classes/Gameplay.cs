using GameEngine.Interfaces;
using GameEngine.Services;
using GameServices.Classes;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Classes
{
    public class Gameplay : IGamePlay
    {
        private readonly ITextService _textService;

        private readonly ICommandTaker _commandTaker;

        private readonly IStorage _storage;
        


        

        public Gameplay(IField field, ITextService textservice, ICommandTaker commandTaker, IStorage storage)
        {
            _textService = textservice;
            _commandTaker = commandTaker;
            _storage = storage;
        }

        

        public void Start()
        {
            while (true)
            {
                _textService.Clear();
                for (int i = 0; i < _storage.PlayersCount; i++)
                {
                    _textService.Write(_storage.Players[i].Name + " " + "player turn. Enter coordinates");
                    _textService.Write("Example --> 2 3");
                    string input = _textService.Read();
                    _commandTaker.TakeCommand(input, i);
                    if (_storage.ZeroFound)
                    {
                        _textService.Clear();
                        _textService.Write("Game Ended!");
                        foreach (var player in _storage.Players)
                        {
                            _textService.Write(player.Name);
                            _textService.Write(player.Points.ToString() + " " + "Points");
                            _textService.Write("------------------");
                        }
                        break;
                    }

                }
                if (_storage.ZeroFound)
                {
                    break;
                }
            }
        }

    }
}
