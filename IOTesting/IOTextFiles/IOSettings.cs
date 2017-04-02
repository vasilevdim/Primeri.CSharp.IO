using System;
namespace IOTextFiles
{
	public class IOSettings
	{

		private STable _stable;


		public IOSettings(STable stable)
		{
			_stable = stable;

		}

		public bool save()
		{
			try
			{
				string _temp = "";

				_temp = String.Join("\r\n", _stable.stable);

				//Zapis na tekstov fail

				System.IO.File.WriteAllText("C:\\aula\\test.txt", _temp);

				return true;
			}
			catch
			{

			}
			return false;
		}

	}
}
