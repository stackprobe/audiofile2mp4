using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Charlotte.Tools;

namespace Charlotte
{
	public class CommonUtils
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
			List<Control.ControlCollection> controlTable = new List<Control.ControlCollection>();

			controlTable.Add(f.Controls);

			for (int index = 0; index < controlTable.Count; index++)
			{
				foreach (Control control in controlTable[index])
				{
					GroupBox gb = control as GroupBox;

					if (gb != null)
					{
						controlTable.Add(gb.Controls);
					}
					TabControl tc = control as TabControl;

					if (tc != null)
					{
						foreach (TabPage tp in tc.TabPages)
						{
							controlTable.Add(tp.Controls);
						}
					}
					SplitContainer sc = control as SplitContainer;

					if (sc != null)
					{
						controlTable.Add(sc.Panel1.Controls);
						controlTable.Add(sc.Panel2.Controls);
					}
					Panel p = control as Panel;

					if (p != null)
					{
						controlTable.Add(p.Controls);
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
						ToolStripMenuItem item = new ToolStripMenuItem();

						item.Text = "項目なし";
						item.Enabled = false;

						ContextMenuStrip menu = new ContextMenuStrip();

						menu.Items.Add(item);

						c.ContextMenuStrip = menu;
					}
				}
			});
		}

		// < sync
	}
}
