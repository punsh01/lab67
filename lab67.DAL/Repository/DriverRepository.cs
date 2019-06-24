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
	public class DriverRepository : IRepository<Driver>
	{
		private Context db;

		public DriverRepository(Context context)
		{
			this.db = context;
		}

		public void Create(Driver item)
		{
			db.Drivers.Add(item);
		}

		public void Delete(int id)
		{
			Driver driver = db.Drivers.Find(id);
			if (driver != null)
				db.Drivers.Remove(driver);
		}

		public Driver Get(int id)
		{
			return db.Drivers.Find(id);
		}

		public IEnumerable<Driver> GetAll()
		{
			return db.Drivers;
		}

		public void Update(Driver item)
		{
			db.Entry(item).State = EntityState.Modified;
		}
	}
}
