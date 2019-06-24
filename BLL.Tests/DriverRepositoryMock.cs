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
	public class DriverRepositoryMock : IRepository<Driver>
	{
		LinkedList<Driver> drivers;

		public DriverRepositoryMock()
		{
			drivers = new LinkedList<Driver>();
		}
		public void Create(Driver item)
		{
			drivers.AddLast(item);
		}

		public void Delete(int id)
		{
			foreach ( var item in drivers)
			{
				if (item.DriverId == id)
					drivers.Remove(item);
			}
		}

		public Driver Get(int id)
		{

			foreach (var item in drivers)
			{
				if (item.DriverId == id)
					return item;
			}

			return new Driver();
		}

		public IEnumerable<Driver> GetAll()
		{
			return drivers;
		}

		public void Update(Driver other)
		{
			foreach (var item in drivers)
			{
				if (item.DriverId == other.DriverId)
				{

					drivers.Remove(item);
					drivers.AddLast(other);
				}
			}
		}
	}
}
