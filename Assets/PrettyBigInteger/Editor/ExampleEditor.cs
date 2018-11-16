using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Example))]
public class ExampleEditor : Editor {

	long inputValue = 0;

	public override void OnInspectorGUI()
	{
		Example script = (Example)target;

		inputValue = EditorGUILayout.LongField("INPUT TEST VALUE HERE", inputValue);

		if (GUILayout.Button("Convert to Strings")) {
			script.updateExample(inputValue);
		}
		base.OnInspectorGUI();
	}
}
