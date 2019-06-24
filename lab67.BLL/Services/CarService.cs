using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab67.BLL.Data;
using lab67.BLL.Interfaces;
using lab67.BLL.Actions;

using lab67.DAL.Entities;
using lab67.DAL.Interfaces;

using AutoMapper;

namespace lab67.BLL.Services
{
	public class CarService : ICarService
	{
		private IUnitOfWork m_database { get; set; }

		public CarService(IUnitOfWork db)
		{
			m_database = db;
		}


		public   void MakeCar(CarData carData)
		{
			double currentServiceNeeds = new Serviceability().SetMileage(0).SetActualConditionAssessment(carData.ConditionAssessment).GetСorrection();

			Car car = new Car
			{
				CarId = m_database.GetNextCarIndex(),
				Model = carData.Model,
				Company = carData.Company,
				Capacity = carData.Capacity,
				ConditionAssessment = carData.ConditionAssessment
			};

			m_database.Cars.Create(car);
			m_database.Save();
		}

		public   void SetDriverToCar(int carID, int driverID)
		{
			Car car = m_database.Cars.Get(carID);
			if (car == new Car())
				throw new FieldAccessException("Car not found");

			Driver driver = m_database.Drivers.Get(driverID);
			if (driver == new Driver())
				throw new FieldAccessException("Driver not found");

			car.DriverId = driverID;

			m_database.Cars.Update(car);
			m_database.Save();

		}
		public   void Dispose()
		{
			m_database.Dispose();
		}

		public   double GetCapacity(int id)
		{
			Car car = m_database.Cars.Get(id);
			if (car == new Car())
				throw new FieldAccessException("Car not found");

			return car.Capacity;
		}

		public   IEnumerable<CarData> GetCars()
		{
			var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Car, CarData>()).CreateMapper();
			return mapper.Map<IEnumerable<Car>, List<CarData>>(m_database.Cars.GetAll());
		}

		public   string GetCompany(int id)
		{
			Car car = m_database.Cars.Get(id);
			if (car == new Car())
				throw new FieldAccessException("Car not found");

			return car.Company;
		}

		public   double GetConditionAssessment(int id)
		{
			Car car = m_database.Cars.Get(id);
			if (car == new Car())
				throw new FieldAccessException("Car not found");

			return car.ConditionAssessment;
		}

		public   string GetModel(int id)
		{
			Car car = m_database.Cars.Get(id);
			if (car == new Car())
				throw new FieldAccessException("Car not found");

			return car.Model;
		}
	}
}
