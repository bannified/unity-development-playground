using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour {
	
	public Bannified.PrettyBigInteger prettyBigNumber;

	public string normalString;

	public string outputPrettyString;

	public void updateExample(long inputNumber) {
		BigInteger big = new BigInteger(inputNumber);
		normalString = big.ToString();

		Bannified.PrettyBigInteger prettyBig = new Bannified.PrettyBigInteger(inputNumber);
		prettyBigNumber = prettyBig;
		outputPrettyString = prettyBig.ToString();
	}
}
