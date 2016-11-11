using UnityEngine;
using System.Collections;

public class TestMarker : MonoBehaviour {

	public GameObject prefab;

	// Use this for initialization
	void Start () {
		//OnlineMaps.instance.AddMarker (new Vector2 (-0.268474f, 51.49584f), "Poyo");

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnGUI(){
		if (GUI.Button (new Rect (0, 0, 100, 100), "Instance")) {
			Instance ();
		}
	}

	void Instance(){
		OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (-0.268474f, 51.49584f),prefab);
	}
}
