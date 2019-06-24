using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab67.DAL.Interfaces;
using lab67.DAL.EntityFramework;
using lab67.DAL.Entities;

namespace lab67.DAL.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private Context db;
		private CarRepository carRepository;
		private DriverRepository driverRepository;

		private bool disposed = false;

		public UnitOfWork()
		{
			db = new Context();
		}

		public IRepository<Car> Cars
		{
			get
			{
				if (carRepository == null)
					carRepository = new CarRepository(db);
				return carRepository;
			}
		}

		public IRepository<Driver> Drivers
		{
			get
			{
				if (driverRepository == null)
					driverRepository = new DriverRepository(db);
				return driverRepository;
			}
		}

		public void Save()
		{
			db.SaveChanges();
		}

		public virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					db.Dispose();
				}
				this.disposed = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public int GetNextCarIndex()
		{
			return db.Cars.Count() + 1;
		}
	}
}
