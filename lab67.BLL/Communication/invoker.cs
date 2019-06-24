using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab67.BLL.Interfaces;

namespace lab67.BLL.Communication
{
	public class invoker
	{
		private IExecutor executor;
		public string action { set; get; }

		public invoker(IExecutor i_executor)
		{
			executor = i_executor;
		}

		public void run()
		{
			executor.execute();
		}

	}
}
