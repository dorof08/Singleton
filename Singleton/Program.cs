namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			var singleton1 = SingletonReadWriter.Instance;
			var singleton2 = SingletonReadWriter.Instance;

			singleton1.WtiteText("s1");
			singleton2.WtiteText("s2");

			singleton1.Save();
			singleton2.Save();
		}
	}
}
