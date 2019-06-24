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
	public class UnitOfWorkMock : IUnitOfWork
	{
		private CarRepositoryMock carRepositoryMock;
		private DriverRepositoryMock driverRepositoryMock;

		public IRepository<Car> Cars
		{
			get
			{
				if (carRepositoryMock == null)
					carRepositoryMock = new CarRepositoryMock();
				return carRepositoryMock;
			}
		}

		public IRepository<Driver> Drivers
		{
			get
			{
				if (driverRepositoryMock == null)
					driverRepositoryMock = new DriverRepositoryMock();
				return driverRepositoryMock;
			}
		}

		public void Dispose()
		{
			// TODO
		}

		public int GetNextCarIndex()
		{
			return 4;
		}

		public void Save()
		{
			// TODO
		}
	}
}
