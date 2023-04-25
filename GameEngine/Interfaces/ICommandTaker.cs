using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Interfaces
{
    public interface ICommandTaker
    {
        public void TakeCommand(string input, int playerId);

        public void ExecuteCommand(int row, int column, int playerId);
    }
}
