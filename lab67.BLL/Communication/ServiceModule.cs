using Ninject.Modules;
using lab67.DAL.Interfaces;
using lab67.DAL.Repository;

namespace lab67.BLL.Communication
{
	public class ServiceModule : NinjectModule
	{

		private static ServiceModule instance;

		protected ServiceModule()
		{
		}

		public static ServiceModule GetInstance()
		{
			if (instance == null)
				instance = new ServiceModule();
			return instance;
		}
	
		public override void Load()
		{
			Bind<IUnitOfWork>().To<UnitOfWork>();
		}
	}
}
