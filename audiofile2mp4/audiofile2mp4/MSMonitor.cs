using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charlotte
{
	public class MSMonitor
	{
		public int RowIndex = 0;

		public int ReadyCount = 0;
		public int ProcessingCount = 0;
		public int ErrorCount = 0;
		public int SuccessfulCount = 0;

		public int SelectedCount = 0;
	}
}
