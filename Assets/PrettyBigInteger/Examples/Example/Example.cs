using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour {

	public string normalString;

	public string outputPrettyString;

	[SerializeField]
	Text normalText;
	[SerializeField]
	Text prettyText;

	public int start;
	public float scalingRate;

	Coroutine _countingCR;

	public void ToggleVisualization()
	{
		if (_countingCR == null)
		{
			_countingCR = StartCoroutine(countingCR(start));
		} else
		{
			StopCoroutine(_countingCR);
			_countingCR = null;
		}
	}

	IEnumerator countingCR(int start)
	{
		BigInteger bi = new BigInteger(start);

		while (true)
		{			
			if (bi / new BigInteger(12) > 0)
			{
				bi += bi / new BigInteger(12);
			} else
			{
				bi += bi;
			}
			normalText.text = bi.ToString();
			prettyText.text = bi.ToPrettyString();
			yield return new WaitForSeconds(0.1f);
		}

	}

	public void updateExample(string inputNumber) {
		BigInteger big = new BigInteger(inputNumber, 10);
		normalString = big.ToString();

		outputPrettyString = big.ToPrettyString();

		Debug.Log("Data length = " + big.dataLength);
	}

	public void PrettyTest(int numOfDigits)
	{
		string workingNumber = "";
		for (int i = 0; i < numOfDigits; i++)
		{
			workingNumber += "1";
			BigInteger prettyBig = new BigInteger(workingNumber);
			Debug.Log(i + 1 + " digits\n" + workingNumber + " -----> " + prettyBig.ToPrettyString());
		}
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
