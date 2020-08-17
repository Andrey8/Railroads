using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;



namespace Railroads.Testers
{
	[TestFixture]
	class PermutationHelperTester
	{
		[Test]
		[TestCase( new[] { 3, 2, 1, 5, 4 } )]
		[TestCase( new[] { 4, 6, 5, 3, 7, 2, 1 } )]
		[TestCase( new[] { 4, 7, 6, 8, 5, 3, 9, 2, 10, 1 } )]
		public void TestIsPermutationReachableForCorrectSequences( int[] permutation )
		{
			Assert.IsTrue( PermutationHelper.IsPermutationReachableByMarshalling( permutation ) );
		}

		[Test]
		[TestCase( new[] { 3, 4, 1, 2 } )]
		[TestCase( new[] { 3, 6, 4, 5, 2, 1 } )]
		[TestCase( new[] { 4, 3, 6, 5, 2, 9, 7, 8, 1, 10 } )]
		public void TestIsPermutationReachableForIncorrectSequences( int[] permutation )
		{
			Assert.IsFalse( PermutationHelper.IsPermutationReachableByMarshalling( permutation ) );			
		}
	}
}
