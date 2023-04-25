using GameEntities.Elements.Classes;
using GameEntities.Elements.Interfaces;
using GameServices.Classes;
using GameServices.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameBinding.Binding
{
    public class Bind : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IReader>().To<Reader>();
            this.Bind<IMsg>().To<Msg>();
            this.Bind<INumberGetter>().To<NumberGetter>();
            this.Bind<IBasicElement>().To<Element>();
            this.Bind<IRow>().To<Row>();
            this.Bind<ISymbolGetter>().To<SymbolGetter>();

        }
    }
}
