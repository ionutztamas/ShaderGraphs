#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DitherOutline))]
public class DitherOutlineEditor : Editor
{

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		DitherOutline script = (DitherOutline)target;
		if(GUILayout.Button("Create Outline"))
		{
			script.CreateOutline();
		}
	}

}

#endif