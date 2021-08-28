using System.IO;
using System.Windows.Forms;

namespace ns0
{
	internal class Class0
	{
		public static OpenFileDialog openFileDialog_0 = new OpenFileDialog
		{
			Filter = "Lua Files (*.lua)|*.lua|Text Files (*txt)|*.txt"
		};

		public static void smethod_0(ListBox listBox_0, string string_0, string string_1)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			FileInfo[] files = directoryInfo.GetFiles(string_1);
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				listBox_0.Items.Add(fileInfo.Name);
			}
		}
	}
}
