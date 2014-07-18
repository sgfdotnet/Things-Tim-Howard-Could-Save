using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using Tim.App.Core.Services;

namespace Tim.App.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
			Mvx.RegisterType<IThingsService, ThingsService>();
            RegisterAppStart<ViewModels.ThingsViewModel>();
        }
    }
}