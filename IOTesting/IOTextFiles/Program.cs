using System;

namespace IOTextFiles
{
	class MainClass
	{
		


		public static void Main(string[] args)
		{
			STable _STable = new STable();
			IOSettings _io = new IOSettings(_STable);

			Console.WriteLine(_STable.stable [0]);

			if (_io.save())
			{
				Console.WriteLine("Tablizata e zapametena uspeshno.");

			}
			else
			{
				Console.WriteLine("Tablizata NE e zapametena uspeshno.");
			}
		}
	}
}
