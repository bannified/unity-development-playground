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

		public PrettyBigInteger(long value) : base(value)
		{

		}
	}
}
