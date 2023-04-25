using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Services
{
    public interface ITextService
    {
        public string Read();

        public void Write(string input);

        public void Clear();
    }
}
