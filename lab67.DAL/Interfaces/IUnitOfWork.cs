using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab67.DAL.Entities;

namespace lab67.DAL.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<Car> Cars { get; }
		IRepository<Driver> Drivers { get; }
		int GetNextCarIndex();
		void Save();
	}
}
