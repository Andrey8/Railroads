using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;



namespace Railroads.Testers
{
	[TestFixture]
	class ISSPermutationTester
	{
		[Test]
		[TestCase( new[] { 4, 2, 5, 3, 1 } )]
		[TestCase( new[] { 4, 7, 2, 10, 3, 8, 1, 6, 9, 5 } )]
		[TestCase( new[] { 6, 8, 10, 7, 5, 3, 1, 2, 4, 9 } )]
		public void TestConstructorForCorrectSequences( int[] numbers )
		{
			Assert.DoesNotThrow( () => { var p = new IntegersStartingSegmentPermutation( numbers ); } );
		}

		[Test]
		[TestCase( new[] { 3, 6, 2, 1, 4 } )]
		[TestCase( new[] { 5, 2, 7, 1, 2, 8, 6, 4 } )]
		[TestCase( new[] { 6, 8, 10, 9, 5, 3, 1, 2, 4, 9, 7 } )]
		public void TestConstructorForIncorrectSequences( int[] numbers )
		{
			Assert.Throws< ArgumentException >( () => { var p = new IntegersStartingSegmentPermutation( numbers ); } );
		}
	}
}
