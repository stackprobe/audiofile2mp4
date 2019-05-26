using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Charlotte
{
	public class Converter
	{
		private ConverterTask Task = null;

		public void Start(ConverterTask task)
		{
			if (task == null)
				throw null;

			if (this.Task != null)
				throw null;

			this.Task = task;
			this.Task.Start();
		}

		public bool IsReady()
		{
			return this.Task == null;
		}

		public bool IsCompleted()
		{
			return this.Task != null && this.Task.IsCompleted();
		}

		public ConverterTask GetTask()
		{
			if (this.Task == null)
				throw null;

			return this.Task;
		}

		public void Reset()
		{
			this.Task = null;
		}
	}
}
