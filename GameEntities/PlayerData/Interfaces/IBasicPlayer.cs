using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEntities.PlayerData.Interfaces
{
    public interface IBasicPlayer
    {

        public string Name { get; set; }

        public int Points { get; set; }
    }
}
