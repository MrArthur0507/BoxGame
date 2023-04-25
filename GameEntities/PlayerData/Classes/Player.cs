using GameEntities.PlayerData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEntities.PlayerData.Classes
{
    public class Player : IBasicPlayer
    {
        public string Name { get; set; }

        public int Points { get; set; }

        public Player() { }

        public Player(string name) {
            Name = name;
        }
    }
}
