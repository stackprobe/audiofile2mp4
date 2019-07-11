using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charlotte
{
	public class MSMonitor
	{
		private int StartCountdown = 10;

		public bool IsStarted()
		{
			if (1 <= this.StartCountdown)
			{
				this.StartCountdown--;
				return false;
			}
			if (this.StartCountdown == 0)
			{
				this.Again = false;
				this.StartCountdown = -1;
			}
			return true;
		}

		public int RowIndex = 0;

		public int ReadyCount = 0;
		public int ProcessingCount = 0;
		public int ErrorCount = 0;
		public int SuccessfulCount = 0;

		public string GetOutput()
		{
			return "待機中 = " + this.ReadyCount +
				" / 処理中 = " + this.ProcessingCount +
				" / 失敗 = " + this.ErrorCount +
				" / 成功 = " + this.SuccessfulCount;
		}

		public enum Status_e
		{
			READY,
			完了,
			完了エラーあり,
			処理中,
			処理中エラーあり,
		}

		public Status_e GetStatus()
		{
			if (this.ProcessingCount + this.ErrorCount + this.SuccessfulCount == 0)
				return Status_e.READY;

			return (Status_e)
				(this.ReadyCount + this.ProcessingCount == 0 ? 1 : 3) +
				(this.ErrorCount == 0 ? 0 : 1);
		}

		public bool Again = false;
	}
}
