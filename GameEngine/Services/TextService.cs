using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Services
{
    public class TextService : ITextService
    {
        private readonly IMsg _msg;

        private readonly IReader _reader;

        private readonly IClearScreen _clearScreen;
        public TextService(IMsg msg, IReader reader, IClearScreen clearScreen) {
            _msg = msg;

            _reader = reader;

            _clearScreen = clearScreen;
        }

        public string Read()
        {
           return  _reader.Read();
        }

        public void Write(string input)
        {
            _msg.Print(input);
        }

        public void Clear()
        {
            _clearScreen.Clear();
        }
    }
}
