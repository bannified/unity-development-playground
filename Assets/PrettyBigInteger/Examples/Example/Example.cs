using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour {
	
	public Bannified.PrettyBigInteger prettyBigNumber;

	public string normalString;

	public string outputPrettyString;

	public void updateExample(string inputNumber) {
		BigInteger big = new BigInteger(inputNumber, 10);
		normalString = big.ToString();

		Bannified.PrettyBigInteger prettyBig = new Bannified.PrettyBigInteger(inputNumber);
		prettyBigNumber = prettyBig;
		outputPrettyString = prettyBig.ToString();

		Debug.Log("Data length = " + prettyBig.dataLength);
	}


	public void BenchmarkPBI(int noOfLoops, string testString)
	{
		Debug.Log("----- START OF PrettyBigInteger Benchmark --------");
		
		if (testString == null || testString == "")
		{
			System.DateTime time = System.DateTime.Now;
			for (int i = 0; i < noOfLoops; i++)
			{
				new Bannified.PrettyBigInteger();
			}
			Debug.Log("Time taken: " + (System.DateTime.Now - time));
			Debug.Log("End of PrettyBigInteger Benchmark");
		} else
		{
			System.DateTime time = System.DateTime.Now;
			for (int i = 0; i < noOfLoops; i++)
			{
				new Bannified.PrettyBigInteger(testString);
			}
			Debug.Log("Time taken: " + (System.DateTime.Now - time));
			Debug.Log("End of PrettyBigInteger Benchmark");
		}
		

	}

}
