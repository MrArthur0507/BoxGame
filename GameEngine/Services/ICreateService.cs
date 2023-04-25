using GameServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Services
{
    public interface ICreateService
    {
        public void CreatePlayer(int count);

        public IField CreateField(int cap);
    }
}
