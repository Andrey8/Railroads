using System;
using System.Collections.Generic;
using System.Linq;



namespace Railroads
{
	public class IntegersStartingSegmentPermutation
	{
		int length;
		public readonly int[] Numbers;



		public IntegersStartingSegmentPermutation( int[] numbers )
		{
			if ( !IsPermutation( numbers ) )
			{
				throw new ArgumentException( "Sequence of numbers is not a permutation." );
			}

			this.length = numbers.Length;
			this.Numbers = numbers;
		}

		

		static bool IsPermutation( int[] numbers )
		{
			int n = numbers.Length;

			var temp = new bool[ n ];
			for ( int i = 0; i < n; ++i )
			{
				temp[ i ] = false;
			}

			for ( int i = 0; i < n; ++i )
			{
				int j = numbers[ i ];
				if ( j >= 1 && j <= n && !temp[ j - 1 ] )
				{
					temp[ j - 1 ] = true;
				}
				else
				{
					return false;
				}
			}

			return true;
		}
	}
}
