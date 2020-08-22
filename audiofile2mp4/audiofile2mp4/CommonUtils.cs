﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Charlotte.Tools;

namespace Charlotte
{
	public static class CommonUtils
	{
		public static string GetConverterFile()
		{
			string file = "Converter.exe";

			if (File.Exists(file) == false)
			{
				file = @"..\..\..\..\Converter\Converter\bin\Release\Converter.exe"; // Debug は Press ENTER があるため、

				if (File.Exists(file) == false)
					throw new Exception("no Converter.exe");
			}
			return file;
		}

		public static string GetImgToolsFile()
		{
			string file = "ImgTools.exe";

			if (File.Exists(file) == false)
			{
				file = @"C:\app\Kit\ImgTools\ImgTools.exe";

				if (File.Exists(file) == false)
					throw new Exception("no ImgTools.exe");
			}
			return file;
		}

		public static string GetBmpToCsvFile()
		{
			string file = "BmpToCsv.exe";

			if (File.Exists(file) == false)
			{
				file = @"C:\app\Kit\BmpToCsv\BmpToCsv.exe";

				if (File.Exists(file) == false)
					throw new Exception("no BmpToCsv.exe");
			}
			return file;
		}

		public static string GetMasterFile()
		{
			string file = "Master.exe";

			if (File.Exists(file) == false)
			{
				file = @"C:\Factory\Program\WavMaster\Master.exe";

				if (File.Exists(file) == false)
					throw new Exception("no Master.exe");
			}
			return file;
		}

		public static string Encode(string str)
		{
			return new Base64Unit().Encode(Encoding.UTF8.GetBytes(str));
		}

		public static bool IsRootDir(string dir)
		{
			string fmt = dir;

			fmt = StringTools.ReplaceChars(fmt, StringTools.ALPHA + StringTools.alpha, 'A');

			return fmt == "A:\\";
		}

		// sync > @ PostShown

		public static void PostShown_GetAllControl(Form f, Action<Control> reaction)
		{
			Queue<Control.ControlCollection> controlTable = new Queue<Control.ControlCollection>();

			controlTable.Enqueue(f.Controls);

			while (1 <= controlTable.Count)
			{
				foreach (Control control in controlTable.Dequeue())
				{
					GroupBox gb = control as GroupBox;

					if (gb != null)
					{
						controlTable.Enqueue(gb.Controls);
					}
					TabControl tc = control as TabControl;

					if (tc != null)
					{
						foreach (TabPage tp in tc.TabPages)
						{
							controlTable.Enqueue(tp.Controls);
						}
					}
					SplitContainer sc = control as SplitContainer;

					if (sc != null)
					{
						controlTable.Enqueue(sc.Panel1.Controls);
						controlTable.Enqueue(sc.Panel2.Controls);
					}
					Panel p = control as Panel;

					if (p != null)
					{
						controlTable.Enqueue(p.Controls);
					}
					reaction(control);
				}
			}
		}

		public static void PostShown(Form f)
		{
			PostShown_GetAllControl(f, control =>
			{
				Control c = new Control[]
				{
					control as TextBox,
					control as NumericUpDown,
				}
				.FirstOrDefault(v => v != null);

				if (c != null)
				{
					if (c.ContextMenuStrip == null)
					{
						ContextMenuStrip menu = new ContextMenuStrip();

#if true
						{
							ToolStripMenuItem item = new ToolStripMenuItem();

							item.Text = "内容をコピー";
							item.Click += (sdr, ev) =>
							{
								try
								{
									Clipboard.SetText(c.Text ?? "");
								}
								catch
								{ }
							};

							menu.Items.Add(item);
						}
#else
						{
							ToolStripMenuItem item = new ToolStripMenuItem();

							item.Text = "項目なし";
							item.Enabled = false;

							menu.Items.Add(item);
						}
#endif

						c.ContextMenuStrip = menu;
					}
				}
			});
		}

		// < sync
	}
}
