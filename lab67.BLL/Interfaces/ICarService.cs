using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab67.BLL.Data;

namespace lab67.BLL.Interfaces
{
	public interface ICarService
	{
		void MakeCar(CarData carData);
		void SetDriverToCar(int carID, int driverID);
		 IEnumerable<CarData> GetCars();
		 string GetModel(int id);
		 string GetCompany(int id);
		 double GetCapacity(int id);
		 double GetConditionAssessment(int id);
		 void Dispose();
	}
}
