using GameEngine.Interfaces;
using GameEntities.PlayerData.Classes;
using GameEntities.PlayerData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Classes
{
    public class Move : IMove
    {
        public Move(IBasicPlayer player, int row, int column)
        {
            Player = player;
            Row = row;
            Column = column;
        }

        public IBasicPlayer Player { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }
    }
}
