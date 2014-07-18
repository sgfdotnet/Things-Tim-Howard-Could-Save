using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;

namespace Tim.App.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<ViewModels.ThingsViewModel>();
        }
    }
}