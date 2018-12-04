using UnityEngine;
using UnityEditor;

namespace Glazed
{
	[CustomEditor(typeof(Example))]
	public class ExampleEditor : Editor
	{

		string inputValue;

		int numberOfTestDigits;

		int numberOfLoops;

		public override void OnInspectorGUI()
		{
			Example script = (Example)target;

			inputValue = EditorGUILayout.TextField("INPUT TEST VALUE HERE", inputValue);


			if (GUILayout.Button("Convert to Strings"))
			{
				script.updateExample(inputValue);
			}

			numberOfLoops = EditorGUILayout.IntField("Number of Loops", numberOfLoops);

			if (GUILayout.Button("PBI Benchmark"))
			{
				script.BenchmarkPBI(numberOfLoops, inputValue);
			}

			numberOfTestDigits = EditorGUILayout.IntField("Number of Test Digits", numberOfTestDigits);

			if (GUILayout.Button("Pretty Digits Test"))
			{
				script.PrettyTest(numberOfTestDigits);
			}

			base.OnInspectorGUI();
		}
	}
}
