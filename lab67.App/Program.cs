using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninject;
using Ninject.Modules;

using lab67.BLL.Communication;
using lab67.App.Communication;

namespace lab67.App
{
	class Program
	{
		static void Main(string[] args)
		{

			NinjectModule serviceModule = ServiceModule.GetInstance();
			//serviceModule.Load();

			NinjectModule carModule = new CarModule();
			//carModule.Load();


		}
	}
}
