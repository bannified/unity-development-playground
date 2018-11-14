namespace Bannified
{
	using System.Numerics;
    using System;
    
    [Serializable]
	public class PrettyBigInteger //: IFormattable, IComparable, IComparable<PrettyBigInteger>, IEquatable<PrettyBigInteger>
	{
        public BigInteger Value;

        #region Operator Overloads
        
        
        public static PrettyBigInteger operator +(PrettyBigInteger value1, int value2)
        {
            return new PrettyBigInteger(value1.Value + value2);
        }
        
        public static PrettyBigInteger operator /(PrettyBigInteger value1, PrettyBigInteger value2)
        {
            return new PrettyBigInteger(value1.Value / value2.Value);
        }
        
        public static PrettyBigInteger operator *(PrettyBigInteger value1, PrettyBigInteger value2)
        {
            return new PrettyBigInteger(value1.Value * value2.Value);
        }
        
        public static PrettyBigInteger operator -(PrettyBigInteger value1, PrettyBigInteger value2)
        {
            return new PrettyBigInteger(value1.Value - value2.Value);
        }
        
        public static PrettyBigInteger operator +(PrettyBigInteger value1, PrettyBigInteger value2)
        {
            return new PrettyBigInteger(value1.Value + value2.Value);
        }        
        
        public static implicit operator PrettyBigInteger(int value)
        {
            return new PrettyBigInteger(value);
        }
        
        public static implicit operator PrettyBigInteger(BigInteger value) {
            return new PrettyBigInteger(value);
        }
        
        public static explicit operator BigInteger(PrettyBigInteger pbi) {
            return pbi.Value;
        }

        #endregion
        
        #region Constructors
        
        public PrettyBigInteger(int integer) : this(new BigInteger(integer)) {
        }
        
        private PrettyBigInteger(BigInteger bigInt) {
            Value = bigInt;
        }
        
        #endregion

    }
}
