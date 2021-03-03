using System;
using System.IO;

namespace Singleton
{
	sealed class SingletonReadWriter
	{
		private static readonly Lazy<SingletonReadWriter> instance = new Lazy<SingletonReadWriter>(() => new SingletonReadWriter());

		public static SingletonReadWriter Instance { get { return instance.Value; } }

		public string FilePath { get; }
		public string Text { get; private set; }

		private SingletonReadWriter()
		{
			FilePath = "text.txt";
			ReadFromTxt();
		}

		public void WtiteText(string text)
		{
			Text += text;
		}

		public void Save()
		{
			using (var writer = new StreamWriter(FilePath))
				writer.WriteLine(Text);
		}

		private void ReadFromTxt()
		{
			if (File.Exists(FilePath))
			{
				using (var reader = new StreamReader(FilePath))
					Text = reader.ReadToEnd();
			}
			else
			{
				Text = "";
			}
		}
	}
}
