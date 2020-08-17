using System;
using System.Collections.Generic;
using System.Linq;



namespace Railroads
{
	public static class PermutationHelper
	{
		public static bool IsPermutationReachableByMarshalling( int[] permutation )
		{
			int n = permutation.Length;

			var stack1 = new Stack<int>( permutation );
			var stack2 = new Stack<int>();

			for ( int i = n; i >= 1; --i )
			{
				if ( stack1.Contains( i ) )
				{
					while ( i != stack1.Peek() )
					{
						stack2.Push( stack1.Pop() );
					}
					stack1.Pop();

					continue;
				}
				else if ( stack2.Count >= 1 && i == stack2.Peek() )
				{
					stack2.Pop();

					continue;
				}

				return false;
			}
			
			return true;
		}
	}
}
