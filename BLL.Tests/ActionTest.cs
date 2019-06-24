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

namespace lab67.BLL.Tests
{
	[TestFixture]
	public class ActionTest
	{
		[TestCase]
		public void ChangeRate()
		{
			const double checkSum = 76.3;
			double res = new Serviceability().SetMileage(50000).SetActualConditionAssessment(86.3).GetСorrection();

			Assert.AreEqual(res , checkSum);
		}

	}
}
