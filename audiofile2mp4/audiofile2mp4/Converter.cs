using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Charlotte
{
	public class Converter
	{
		private Thread Th = null;
		private ConverterTask Task = null;

		public void Start(ConverterTask task)
		{
			if (task == null)
				throw null;

			if (this.Th != null)
				throw null;

			this.Task = task;
			this.Th = new Thread(task.MainTh);
			this.Th.Start();
		}

		public bool IsReady()
		{
			if (this.Th != null && this.Th.IsAlive == false)
				this.Th = null;

			return this.Th == null;
		}

		public bool IsCompleted()
		{
			return this.IsReady() && this.Task != null;
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
