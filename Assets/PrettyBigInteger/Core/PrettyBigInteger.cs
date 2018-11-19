namespace Bannified
{
    using System;

	[Serializable]
	public class PrettyBigInteger : BigInteger
	{

		public static readonly string[] standardSuffixesSet = { " ", "K", "M", "B", "T" };

		const string specialSuffixCharSet = " abcdefghijklmnopqrstuvwxyxABCDEFGHIJKLMNOPQRSTUVWXYZ";

		const int numberOfDec = 2;

		public override string ToString()
		{
			return ToPrettyString();
		}

		public string ToStandardString()
		{
			return base.ToString();
		}

		public string ToPrettyString()
		{
			string fullString = base.ToString();

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
			} else
			{
				result = String.Join("", number, standardSuffixesSet[suffixIndex]); // K
			}

			return result;
		}

		public PrettyBigInteger() : base() {}

		public PrettyBigInteger(long value) : base(value) {}

		public PrettyBigInteger(int value) : base(value) {}

		public PrettyBigInteger(string value) : base(value, 10) { }
	}
}
