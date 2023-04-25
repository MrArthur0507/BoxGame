using GameEngine.Interfaces;
using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Services
{
    public class CreateService : ICreateService
    {
        private readonly IPlayerCreator _playerCreator;

        private readonly IFieldCreator _fieldCreator;

        public CreateService(IPlayerCreator playerCreator, IFieldCreator fieldCreator)
        {
            _playerCreator= playerCreator;
            _fieldCreator= fieldCreator;
        }

        public void CreatePlayer(int count)
        {
            _playerCreator.Create(count);
        }

        public IField CreateField(int cap)
        {
           return _fieldCreator.CreateField(cap);
        }
    }
}
