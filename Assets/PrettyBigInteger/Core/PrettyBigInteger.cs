namespace Bannified
{
    using System;

	[Serializable]
	public class PrettyBigInteger : BigInteger
	{
		public override string ToString()
		{


			return base.ToString();
		}

		public PrettyBigInteger() : base() {}

		public PrettyBigInteger(long value) : base(value) {}

		public PrettyBigInteger(int value) : base(value) {}

		public PrettyBigInteger(string value) : base(value, 10) { }
	}
}
