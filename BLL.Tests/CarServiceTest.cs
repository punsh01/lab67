using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using NUnit.Compatibility;

using lab67.BLL.Interfaces;
using lab67.BLL.Data;
using lab67.BLL.Services;

using lab67.DAL.Entities;

namespace lab67.BLL.Tests
{
	[TestFixture]
	public class CarServiceTest
	{
		private ICarService m_carService = null;

		[SetUp]
		public void Init()
		{
			m_carService = new CarService(new UnitOfWorkMock());
		}

		[Test]
		public void AddNewCar_CompereElements_ExpectedEq()
		{

			CarData car = new CarData
			{
				Model = "V2P6",
				Company = "VAZ",
				Capacity = 12.5,
				ConditionAssessment = 86.2
			};

			m_carService.MakeCar(car);

			CarData tryGet = m_carService.GetCars().First();

			Assert.AreEqual(	tryGet.Model, car.Model);
			Assert.AreEqual(	tryGet.Company, car.Company);
			Assert.AreEqual(	tryGet.Capacity, car.Capacity);
			Assert.AreEqual(	tryGet.ConditionAssessment, car.ConditionAssessment);
		}

		[Test]
		public void SetDriverId_ExpectedExcept()
		{

			CarData car = new CarData
			{
				Model = "V2P6",
				Company = "VAZ",
				Capacity = 12.5,
				ConditionAssessment = 86.2
			};

			try
			{
				m_carService.SetDriverToCar(1, 1);
			}
			catch(FieldAccessException ex)
			{
				Assert.AreEqual(ex.Message, "Driver not found");
			}
			catch(Exception ex)
			{
				Assert.Fail(ex.Message);
			}
		}

		[Test]
		public void ComperCapacity2SimilaryCar_ExpectedEq()
		{
			CarData car = new CarData
			{
				Model = "V2P6",
				Company = "VAZ",
				Capacity = 12.5,
				ConditionAssessment = 86.7
			};

			CarData car2 = new CarData
			{
				Model = "V2P6111",
				Company = "VAZ",
				Capacity = 12.5,
				ConditionAssessment = 58.2
			};

			double cap_car1 = m_carService.GetCapacity(1);
			double cap_car2 = m_carService.GetCapacity(2);

			Assert.AreEqual(cap_car1, cap_car2);
		}
	}
}
