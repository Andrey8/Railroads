using System;
using System.Collections.Generic;
using NUnitLite;
using System.IO;



namespace Railroads
{
	class Program
	{
		static void DoTask()
		{
			try
			{
				var service = new Service();
				string inputFilePath = "InputFile.txt";
				string outputFilePath = "OutputFile.txt";

				var data = service.ReadData( inputFilePath );

				File.WriteAllText( outputFilePath, string.Empty );

				service.WriteResult( outputFilePath, data );
			}
			catch( Exception exc )
			{
				Console.WriteLine( exc.Message );
			}
		}

		static void Main( string[] args )
		{
			//( new AutoRun() ).Execute( args );
			DoTask();
		}
	}
}
