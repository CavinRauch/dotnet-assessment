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

			for (int i = 0; i < numbers.Length; i++)
			{
				//Left
				var leftTrailingIndex = i - 1;
				leftToRight[i] = numbers[i];
				if (leftTrailingIndex >= 0)
					leftToRight[i] += leftToRight[leftTrailingIndex];

				//Right
				//var correctedIndex = (numbers.Length - 1);
				//var rightTrailingIndex = 
				//rightToLeft[numbers.Length] = numbers[numbers.Length];
				//if (numbers.Length - i )
				//{

				//}
			}

			return -99;
		}

		public int Sum(int[] numbers)
		{
			var total = 0;

			foreach (var num in numbers)
				total += num;

			return total;
		}
	}
}
