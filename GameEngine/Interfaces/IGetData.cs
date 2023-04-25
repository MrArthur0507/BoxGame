using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Interfaces
{
    public interface IGetData
    {
        public int GetFieldSize();

        public int GetPlayerCount();

        public int GetSymbolCount();

        public void GetSymbol(int cap);
    }
}
