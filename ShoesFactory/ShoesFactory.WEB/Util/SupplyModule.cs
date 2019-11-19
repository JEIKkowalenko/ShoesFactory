using Ninject.Modules;
using ShoesFactory.BLL.Interfaces;
using ShoesFactory.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoesFactory.WEB.Util
{
    public class SupplyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISupplyService>().To<SupplyService>();
        }
    }
}