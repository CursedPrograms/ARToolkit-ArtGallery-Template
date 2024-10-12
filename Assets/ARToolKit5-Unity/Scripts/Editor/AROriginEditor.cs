using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;
using System.IO;

[CustomEditor(typeof(AROrigin))]
public class AROriginEditor : Editor
{
	
    public override void OnInspectorGUI()
    {
        AROrigin o = (AROrigin)target;
        if (o == null) return;
		
		o.findMarkerMode = (AROrigin.FindMode)EditorGUILayout.EnumPopup("ARMarker find mode", o.findMarkerMode);
		
		if (o.findMarkerMode == AROrigin.FindMode.AutoByTags) {
			serializedObject.Update();
			EditorGUILayout.PropertyField(serializedObject.FindProperty("findMarkerTags"), true);
			serializedObject.ApplyModifiedProperties();
		}
    }

}