using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charlotte
{
	public class MSMonitor
	{
		private int FreezeCount = 10;

		public bool IsFreeze()
		{
			return 1 <= this.FreezeCount && this.FreezeCount-- != -1;
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
			完了,
			完了エラーあり,
			処理中,
			処理中エラーあり,
		}

		public Status_e GetStatus()
		{
			return (Status_e)
				(this.ReadyCount + this.ProcessingCount == 0 ? 0 : 2) +
				(this.ErrorCount == 0 ? 0 : 1);
		}
	}
}
