using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using lab67.DAL.Interfaces;
using lab67.DAL.Entities;
using lab67.DAL.EntityFramework;

namespace lab67.DAL.Repository
{
	public class CarRepository : IRepository<Car>
	{
		private Context db;

		public CarRepository(Context context)
		{
			this.db = context;
		}

		public void Create(Car item)
		{
			db.Cars.Add(item);
		}

		public void Delete(int id)
		{
			Car car = db.Cars.Find(id);
			if (car != null)
				db.Cars.Remove(car);
		}

		public Car Get(int id)
		{
			return db.Cars.Find(id);
		}

		public IEnumerable<Car> GetAll()
		{
			return db.Cars;
		}

		public void Update(Car item)
		{
			db.Entry(item).State = EntityState.Modified;
		}
	}
}
