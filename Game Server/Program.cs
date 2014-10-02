using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Server.Ninject;
using Ninject;

namespace Game_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            KernelBase kernel = NinjectInit.GetInitializedKernel();
            var controller = kernel.Get<GameServerController>();
            controller.Initialize();
        }
    }
}
