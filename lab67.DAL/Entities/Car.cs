using System.Collections.Generic;

namespace lab67.DAL.Entities
{
	public class Car
	{
		public int CarId { get; set; }
		public int DriverId { get; set; }
		public string Model { get; set; }
		public string Company { get; set; }
		public double Capacity { get; set; }
		public double ConditionAssessment { get; set; }
	}
}
