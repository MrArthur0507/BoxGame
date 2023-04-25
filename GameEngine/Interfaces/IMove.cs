using GameEntities.PlayerData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Interfaces
{
    public interface IMove
    {
        public IBasicPlayer Player { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }
    }
}
