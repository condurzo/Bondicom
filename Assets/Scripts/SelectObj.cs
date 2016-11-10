//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEditor;
//
//public class SelectObj : MonoBehaviour {
//
//	void Start(){
//		SelectLayer(1);
//	}
//
//	public void SelectLayer(int layerNum) {
//		var objs = Selection.GetFiltered(typeof(GameObject), SelectionMode.Deep);
//
//		var list = new List<Object>(objs.Length);
//
//		foreach (var obj in objs) {
//			var go = obj as GameObject;
//
//			if (go == null) continue;
//
//			if (go.layer == layerNum) {
//				list.Add(go);
//			}
//
//			Selection.objects = list.ToArray();
//		}
//
//		var layerName = LayerMask.LayerToName(layerNum);
//
//
//		GameObject[]gos = GameObject.FindGameObjectsWithTag("Mapa");
//		Selection.objects = gos;
//
//	}
//}