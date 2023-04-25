using GameEngine;
using GameEngine.Classes;
using GameEngine.Interfaces;
using GameEngine.Services;
using GameEntities.Elements.Classes;
using GameEntities.Elements.Interfaces;
using GameServices.Classes;
using GameServices.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxGame.Ninject
{
    public class Binding : NinjectModule
    {
        public override void Load()
        {
            this.Bind<Random>().To<Random>().InSingletonScope();
             this.Bind<IReader>().To<Reader>();
             this.Bind<IMsg>().To<Msg>();
             this.Bind<INumberGetter>().To<NumberGetter>();
             this.Bind<IBasicElement>().To<Element>();
             this.Bind<IRow>().To<Row>();
             this.Bind<ISymbolGetter>().To<SymbolGetter>();
             this.Bind<IField>().To<Field>();
             this.Bind<IRowCreator>().To<RowCreator>();
             this.Bind<IFieldCreator>().To<FieldCreator>();
             this.Bind<ISymbolStorage>().To<SymbolStorage>().InSingletonScope();
            this.Bind<IStorage>().To<Storage>().InSingletonScope();
            this.Bind<IGetData>().To<GetData>();
            this.Bind<IGamePlay>().To<Gameplay>();
            this.Bind<ICommandTaker>().To<CommandTaker>();
            this.Bind<ICreateService>().To<CreateService>();
            this.Bind<ITextService>().To<TextService>();
            this.Bind<IPlayerCreator>().To<PlayerCreator>();
            this.Bind<IClearScreen>().To<ClearScreen>();
             this.Bind<Engine>().ToSelf();
        }
    }
}
