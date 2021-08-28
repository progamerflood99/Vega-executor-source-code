using System;
using System.Windows.Forms;

namespace ns0
{
	internal static class Class1
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Application.Run(new Loader());
		}
	}
}
