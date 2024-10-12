using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ARTransitionalCamera))] 
public class ARTransitionalCameraEditor : ARTrackedCameraEditor 
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

		ARTransitionalCamera artc = (ARTransitionalCamera)target;


        EditorGUILayout.Separator();
		
		bool allowSceneObjects = !EditorUtility.IsPersistent(artc);
		artc.targetObject = (GameObject)EditorGUILayout.ObjectField(artc.targetObject, artc.targetObject.GetType(), allowSceneObjects);

		artc.vrTargetPosition = EditorGUILayout.Vector3Field("VR Position", artc.vrTargetPosition);

		artc.transitionAmount = EditorGUILayout.Slider(artc.transitionAmount, 0, 1);

		artc.automaticTransition = EditorGUILayout.Toggle("Automatic Transition", artc.automaticTransition);
		if (artc.automaticTransition) {
			artc.automaticTransitionDistance = EditorGUILayout.FloatField("Transition Distance", artc.automaticTransitionDistance);
		}

		artc.movementRate = EditorGUILayout.FloatField("VR movement speed (m/s)", artc.movementRate);
    }
}