using GameEngine.Classes;
using GameEngine.Interfaces;
using GameEngine.Services;
using GameEntities.Elements.Classes;
using GameEntities.Elements.Interfaces;
using GameEntities.PlayerData.Classes;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameEngine
{
    public class Engine
    {

        private readonly IGetData _getData;

        private readonly IStorage _gameData;

        private readonly IGamePlay _gp;

        private readonly ICreateService _createService;

        public Engine(ICreateService createService, IGetData getData, IStorage gameData, IGamePlay gameplay)
        {
            _createService = createService;
            _getData = getData;
            _gameData = gameData;
            _gp = gameplay;
        }
        

        public void Load()
        {
            
                _gameData.FieldSize = _getData.GetFieldSize();
                _gameData.SymbolCount = _getData.GetSymbolCount();
                _getData.GetSymbol(_gameData.SymbolCount);
                _gameData.Field = _createService.CreateField(_gameData.FieldSize);
                _gameData.PlayersCount = _getData.GetPlayerCount();
                _createService.CreatePlayer(_gameData.PlayersCount);
                _gp.Start();
            
        }


    }
    }

