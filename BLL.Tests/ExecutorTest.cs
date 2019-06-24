using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using NUnit.Framework;
using NUnit.Compatibility;

using lab67.BLL.Interfaces;
using lab67.BLL.Actions;
using lab67.BLL.Data;
using lab67.BLL.Services;

using lab67.DAL.Entities;
using lab67.BLL.Communication;

using lab67.BLL.Tests;

namespace BLL.Tests
{
	[TestFixture]
	class ExecutorTest
	{
		[TestCase]
		public void Execut()
		{
			Executor executor = new Executor("make", new CarData());

			executor.Init(new UnitOfWorkMock());

			invoker some = new invoker(executor);

			some.run();
			
		}
	}
}
