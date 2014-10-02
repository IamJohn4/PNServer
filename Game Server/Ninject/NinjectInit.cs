using Game_Server.AppSettings;
using Game_Server.Ninject.Modules;
using Ninject;

namespace Game_Server.Ninject
{
    public static class NinjectInit
    {
        public static KernelBase GetInitializedKernel()
        {
            KernelBase kernel = new StandardKernel();
            kernel.Load(new GameServerBaseModule());
            kernel.Load(new PubnubModule(kernel.Get<IPubnubAppSettings>()));
            return kernel;
        }
    }
}
