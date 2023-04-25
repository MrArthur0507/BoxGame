using GameEngine.Classes;
using GameEngine.Interfaces;
using GameEntities.Elements.Interfaces;
using GameEntities.PlayerData.Interfaces;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Services
{
    public class StoreService
    {
        private readonly ISymbolStorage _symbolStorage;

        private readonly IStorage _storage;
        public StoreService(ISymbolStorage symbolStorage, IStorage storage) { 
            _symbolStorage = symbolStorage;
            _storage = storage;
        }

        public void AddSymbol(IBasicElement element)
        {
            _symbolStorage.AddSymbol(element);
        }

        public void AddMove(IBasicPlayer player, int row, int col)
        {
            _storage.Moves.Add(new Move(player, row, col));
        }

        
    }
}
