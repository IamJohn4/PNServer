using Game_Server.AppSettings;
using Game_Server.Factories;
using Ninject.Modules;
using PubNubMessaging.Core;

namespace Game_Server.Ninject.Modules
{
    public class PubnubModule : NinjectModule
    {
        private IPubnubAppSettings _appsettings;

        public PubnubModule(IPubnubAppSettings appSettings)
        {
            _appsettings = appSettings;
        }
        public override void Load()
        {
            Bind<IPubnub>().ToMethod(x => PubnubFactory.GetPubnub(_appsettings));
        }
    }
}
