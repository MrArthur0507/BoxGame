
using GameEngine;
using GameEngine.Classes;
using GameEngine.Interfaces;
using GameEntities.Elements.Classes;
using GameEntities.Elements.Interfaces;
using GameServices.Classes;
using GameServices.Interfaces;
using Ninject;
using System.Reflection;


var kernel = new StandardKernel();
kernel.Load(Assembly.GetExecutingAssembly());

var engine = kernel.Get<Engine>();


engine.Load();


