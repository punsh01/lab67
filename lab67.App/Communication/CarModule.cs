using Ninject;
using Ninject.Modules;
using lab67.BLL.Services;
using lab67.BLL.Interfaces;

namespace lab67.App.Communication
{
	public class CarModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ICarService>().To<CarService>();
		}
	}
}
