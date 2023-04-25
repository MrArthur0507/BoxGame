using GameEntities.PlayerData.Interfaces;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Interfaces
{
    public interface IStorage
    {
        public IField Field { get; set; }
        public List<IBasicPlayer> Players { get; set; }

        public List<IMove> Moves { get; set; }

        public int PlayersCount { get; set; }

        public int FieldSize { get; set; }

        public int SymbolCount { get; set; }

        public bool ZeroFound { get; set; }
    }
}
