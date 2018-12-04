using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Glazed
{
	public class DoubleExample : MonoBehaviour
	{

		public string normalString;

		public string outputPrettyString;

		[SerializeField]
		Text normalText;
		[SerializeField]
		Text prettyText;

		public int start;
		public double scalingRate;

		Coroutine _countingCR;

		public void ToggleVisualization()
		{
			if (_countingCR == null)
			{
				_countingCR = StartCoroutine(countingCR(start, scalingRate));
			}
			else
			{
				StopCoroutine(_countingCR);
				_countingCR = null;
			}
		}

		IEnumerator countingCR(int start, double scalingRate)
		{
			double running = start;

			while (true)
			{
				running += running * scalingRate;
				normalText.text = running.ToString("F0");
				prettyText.text = Bannified.PrettyDouble.DoubleToPrettyDouble(running);
				yield return new WaitForSeconds(0.1f);
			}

		}

		public void updateExample(string inputNumber)
		{
			normalString = inputNumber;

			outputPrettyString = Bannified.PrettyDouble.DoubleToPrettyDouble(double.Parse(inputNumber));
		}

		public void PrettyTest(int numOfDigits)
		{
			string workingNumber = "";
			for (int i = 0; i < numOfDigits; i++)
			{
				workingNumber += "1";
				double value = double.Parse(workingNumber);
				Debug.Log(i + 1 + " digits\n" + value.ToString("F0") + " -----> " + Bannified.PrettyDouble.DoubleToPrettyDouble(value));
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
					double value = 0;
				}
				Debug.Log("Time taken: " + (System.DateTime.Now - time));
				Debug.Log("End of PrettyBigInteger Benchmark");
			}
			else
			{
				System.DateTime time = System.DateTime.Now;
				for (int i = 0; i < noOfLoops; i++)
				{
					double value = double.Parse(testString);
				}
				Debug.Log("Time taken: " + (System.DateTime.Now - time));
				Debug.Log("End of PrettyBigInteger Benchmark");
			}


		}

	}
}
