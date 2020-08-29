using System;
using System.IO;

namespace png2jpg
{
	class Logger
	{
		public string FilePath { get; private set; }
		private StreamWriter sw;

		public Logger(string filePath)
		{
			FilePath = filePath;

			if (File.Exists(filePath)) { File.Delete(FilePath); }
			sw = File.AppendText(FilePath);
			sw.AutoFlush = true;
		}

		public void Write(string text)
		{
			sw.Write(DateTime.Now.ToString() + " - ");
			sw.WriteLine(text);
		}
	}
}
