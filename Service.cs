using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;



namespace Railroads
{
	public class Service
	{
		public List<List<IntegersStartingSegmentPermutation>> ReadData( string inputFilePath )
		{
			var sr = new StreamReader( inputFilePath );

			var permutationBlocks = new List<List<IntegersStartingSegmentPermutation>>();
			while ( true )
			{
				int n = -1;
				if ( !Int32.TryParse( sr.ReadLine(), out n )  )
				{
					throw new Exception();
				}

				if ( n == 0 )
				{
					break;
				}

				var permutations = new List< IntegersStartingSegmentPermutation >();
				string line = sr.ReadLine();
				while ( !line.Equals( "0" ) )
				{
					string[] numbersStrings = line.Split( ' ' );

					var numbers = new List<int>();
					int number = 0;
					foreach ( var s in numbersStrings )
					{
						if ( !Int32.TryParse( s, out number ) )
						{
							throw new Exception();
						}

						numbers.Add( number );
					}

					permutations.Add( new IntegersStartingSegmentPermutation( numbers.ToArray() ) );

					line = sr.ReadLine();
				}

				permutationBlocks.Add( permutations );
			}

			return permutationBlocks;
		}

		public void WriteResult( string outputFilePath, List<List<IntegersStartingSegmentPermutation>> permutationBlocks )
		{
			var result = new List<string>();
			foreach ( var block in permutationBlocks )
			{
				foreach ( var permutation in block )
				{
					if ( PermutationHelper.IsPermutationReachableByMarshalling( permutation.Numbers ) )
					{
						result.Add( "Yes\n" );
					}
					else
					{
						result.Add( "No\n" );
					}
				}

				result.Add( "\n" );
			}

			var sw = new StreamWriter( outputFilePath );
			foreach ( var line in result )
			{
				sw.WriteLine( line );
			}

			sw.Close();
		}
	}
}
