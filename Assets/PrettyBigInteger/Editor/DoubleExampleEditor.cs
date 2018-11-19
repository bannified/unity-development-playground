﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DoubleExample))]
public class DoubleExampleEditor : Editor {

	string inputValue;

	int numberOfTestDigits;

	int numberOfLoops;

	public override void OnInspectorGUI()
	{
		DoubleExample script = (DoubleExample)target;

		inputValue = EditorGUILayout.TextField("INPUT TEST VALUE HERE", inputValue);


		if (GUILayout.Button("Convert to Strings")) {
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
