using System;

namespace TGS.Challenge
{
	/*
		  Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
		  one another return true, else return false

		  "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
		  phrase to produce a new word or phrase, using all the original letters exactly once; for example
		  orchestra can be rearranged into carthorse.

		  areAnagrams("horse", "shore") should return true
		  areAnagrams("horse", "short") should return false

		  NOTE: Punctuation, including spaces should be ignored, e.g.

		  horse!! shore = true
		  horse  !! shore = true
			horse? heroes = true

		  There are accompanying unit tests for this exercise, ensure all tests pass & make
		  sure the unit tests are correct too.
	   */
	public class Anagram
	{
		public bool AreAnagrams(string word1, string word2)
		{
			if (word1 is null || word1 == string.Empty)
				throw new ArgumentException($"{nameof(word1)} cannot be Null", word1);

			if (word2 is null || word2 == string.Empty)
				throw new ArgumentException($"{nameof(word2)} cannot be Null or Empty.", word2);

			return SumOfChars(word1.ToLower()) == SumOfChars(word2.ToLower());
		}

		/// <summary>
		/// Returns the sum of <see cref="char"/> in a <see cref="string"/>
		/// </summary>
		public int SumOfChars(string word)
		{
			var currentValue = 0;

			foreach (var element in word)
				if (Char.IsLetter(element))
					currentValue += element;

			return currentValue;
		}
	}
}
