using System;

namespace Bannified {
	public class PrettyDouble
	{
		public static readonly string[] standardSuffixesSet = { " ", "K", "M", "B", "T" };

		const string specialSuffixCharSet = " abcdefghijklmnopqrstuvwxyxABCDEFGHIJKLMNOPQRSTUVWXYZ";

		const int numberOfDec = 2;

		public static string DoubleToPrettyDouble(double value)
		{
			string fullString = value.ToString("F0");

			int suffixIndex = ((fullString.Length - 1) / 3) % standardSuffixesSet.Length;

			int specialSuffixIndex = ((fullString.Length - 1) / ((standardSuffixesSet.Length) * 3)) % specialSuffixCharSet.Length;

			string result;

			int numberOfWhole = (fullString.Length - 1) % 3 + 1;

			string number = (fullString.Length > 3) ?
				String.Join(".", fullString.Substring(0, numberOfWhole), fullString.Substring(numberOfWhole, numberOfDec)) :
				String.Join(".", fullString.Substring(0, numberOfWhole));

			result = number;

			if (specialSuffixIndex > 0)
			{
				if (suffixIndex == 0)
				{
					result = String.Join("", number, specialSuffixCharSet[specialSuffixIndex]); // a
				}
				else
				{
					result = String.Join("", number, specialSuffixCharSet[specialSuffixIndex], standardSuffixesSet[suffixIndex]); // aK
				}
			}
			else
			{
				result = String.Join("", number, standardSuffixesSet[suffixIndex]); // K
			}

			return result;
		}
	}
}

