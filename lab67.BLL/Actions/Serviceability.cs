using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab67.BLL.Actions
{
	public class Serviceability
	{
		static private double m_actualConditionAssessment = -1.0;
		static private double m_mileage = -1.0;

		public Serviceability()
		{
		}

		public Serviceability SetMileage(double val)
		{
			m_mileage = val;
			return this;
		}

		public Serviceability SetActualConditionAssessment(double val)
		{
			m_actualConditionAssessment = val;
			return this;
		}

		public double GetСorrection()
		{
			if (m_mileage == -1 || m_actualConditionAssessment == -1)
				throw new FieldAccessException("try init data firstly");
			double res = 0.0;

			res = m_actualConditionAssessment - m_mileage / 5000;     // 4 * m_mileage / 20000

			return res;
		}

	}
}
