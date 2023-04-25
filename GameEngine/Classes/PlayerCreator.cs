using GameEngine.Interfaces;
using GameEngine.Services;
using GameEntities.PlayerData.Classes;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Classes
{
    public class PlayerCreator : IPlayerCreator
    {
        private readonly ITextService _textService;

        private readonly IStorage _storage;

        public PlayerCreator(ITextService textService, IStorage storage)         {
            _textService = textService;
            _storage = storage;
        }


        public void Create(int count)
        {
            for (int i = 0; i < count; i++)
            {
                while (true)
                {

                    _textService.Write("Enter " + " " + (i + 1) + " " + "player name");
                    string name = _textService.Read();
                    if (_storage.Players.Any(x => x.Name == name))
                    {
                        _textService.Write("Already exist, enter new username");
                        continue;
                    }
                    else
                    {
                        _storage.Players.Add(new Player(name));
                        break;
                    }


                }
            }
        }
    }
}
