using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Charlotte.Tools;

namespace Charlotte
{
	public class MediaInfo
	{
		public long TotalTimeCentisecond = -1L;
		public int AudioStreamCount = 0;
		public int VideoStreamCount = 0;

		public void SetOutputFile(string file)
		{
			string text = File.ReadAllText(file, Encoding.UTF8);
			string[] lines = FileTools.TextToLines(text);

			foreach (string fLine in lines)
			{
				string line = fLine.Trim();
				string lineFormat = StringTools.ReplaceChars(line, StringTools.DECIMAL, '9');

				if (lineFormat.StartsWith("Duration: 99:99:99.99,"))
				{
					int h = int.Parse(line.Substring(10, 2));
					int m = int.Parse(line.Substring(13, 2));
					int s = int.Parse(line.Substring(16, 2));
					int c = int.Parse(line.Substring(19, 2));

					long t = h;
					t *= 60;
					t += m;
					t *= 60;
					t += s;
					t *= 100;
					t += c;

					this.TotalTimeCentisecond = t;
				}
				else if (line.StartsWith("Stream"))
				{
					if (line.Contains("Audio:"))
					{
						this.AudioStreamCount++;
					}
					else if (line.Contains("Video:"))
					{
						this.VideoStreamCount++;
					}
				}
			}
		}
	}
}
