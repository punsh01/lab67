using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab67.DAL.Entities;
using lab67.DAL.Interfaces;
using lab67.DAL.EntityFramework;
using lab67.DAL.Repository;

namespace lab67.BLL.Tests
{
	public class CarRepositoryMock : IRepository<Car>
	{
		LinkedList<Car> cars;
		public CarRepositoryMock()
		{
			cars = new LinkedList<Car>();
		}
		public void Create(Car item)
		{
			cars.AddLast(item);
		}

		public void Delete(int id)
		{
			foreach (var item in cars)
			{
				if (item.CarId == id)
					cars.Remove(item);
			}
		}

		public Car Get(int id)
		{
			foreach (var item in cars)
			{
				if (item.CarId == id)
					return item;
			}

			return new Car();
		}

		public IEnumerable<Car> GetAll()
		{
			return cars;
		}

		public void Update(Car other)
		{
			foreach (var item in cars)
			{
				if (item.DriverId == other.DriverId)
				{
					cars.Remove(item);
					cars.AddLast(other);
				}
			}
		}
	}
}
