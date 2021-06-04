using System;

namespace TGS.Challenge
{
	/*
		 Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
		 are equal to the sum of all the items to the right of the index.

		 Constraints: 0 <= N <= 100 000

		 Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
		 Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

		 If no index exists then output -1

		 There are accompanying unit tests for this exercise, ensure all tests pass & make
		  sure the unit tests are correct too.
	   */

	public class EquivalenceIndex
	{
		public int Find(int[] numbers)
		{
			var leftToRight = new int[numbers.Length];
			var rightToLeft = new int[numbers.Length];
			var zeroIndexLength = numbers.Length - 1;

			// Create sum arrays
			for (int i = 0; i < numbers.Length; i++)
			{
				//Assign
				var rightPosition = zeroIndexLength - i;
				leftToRight[i] = numbers[i];
				rightToLeft[rightPosition] = numbers[rightPosition];

				//Left
				var leftTrailingIndex = i - 1;
				if (leftTrailingIndex >= 0)
					leftToRight[i] += leftToRight[leftTrailingIndex];

				//Right
				var rightTrailingIndex = rightPosition + 1;
				if (rightTrailingIndex <= zeroIndexLength)
					rightToLeft[rightPosition] += rightToLeft[rightTrailingIndex];
			}

			// Attempt to find
			for (int i = 0; i < numbers.Length; i++)
				if (leftToRight[i] == rightToLeft[i])
					return i;

			return -1;
		}
	}
}
