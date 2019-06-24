using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab67.BLL.Interfaces;
using lab67.BLL.Services;
using lab67.BLL.Data;

using lab67.DAL.Interfaces;

namespace lab67.BLL.Communication
{
	public class Executor : IExecutor
	{
		private string action;
		private CarService carService;
		private CarData car;

		public Executor(string i_action, CarData i_carData)
		{
			action = i_action;
			car = i_carData;
		}

		public void Init(IUnitOfWork unitOfWork)
		{
			carService = new CarService(unitOfWork);
		}
		public void execute()
		{
			if(action == "make")
			{
				carService.MakeCar(car);
			}
			else if (action == "other")
			{
				carService.GetCapacity(0);
			}
		}
	}
}
