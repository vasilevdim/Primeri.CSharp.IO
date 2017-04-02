using System;

namespace IOTextFiles
{
	class MainClass
	{
		


		public static void Main(string[] args)
		{
			STable _STable = new STable();
			IOSettings _io = new IOSettings(_STable);



			if (_io.open())
			{
				Console.WriteLine("Tablizata e prochetena uspeshno.");

			}
			else
			{
				Console.WriteLine("Tablizata NE e prochetena uspeshno.");
			}
			Console.WriteLine(_STable.stable[2]);

		}
	}
}
