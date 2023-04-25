using GameEngine.Interfaces;
using GameEntities.PlayerData.Classes;
using GameEntities.PlayerData.Interfaces;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Classes
{
    public class Storage : IStorage
    {
        public Storage(IField field) { 
            Field = field;
        }
        public IField Field { get; set; }
        public List<IBasicPlayer> Players { get; set; } = new List<IBasicPlayer>();

        public List<IMove> Moves { get; set; } = new List<IMove>();

        public int PlayersCount { get; set; }

        public int FieldSize { get; set; }

        public int SymbolCount { get; set; }

        public bool ZeroFound { get; set; }
    }
}
