using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Server.AppSettings;
using Game_Server.Factories;
using Ninject.Modules;
using PubNubMessaging.Core;

namespace Game_Server.Ninject.Modules
{
    public class GameServerBaseModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGameServerAppSettings>().To<GameServerAppSettings>();
            Bind<IPubnubAppSettings>().To<GameServerAppSettings>();
            Bind<GameServerController>().ToSelf().InSingletonScope();
        }
    }
}
