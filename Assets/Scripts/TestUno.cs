using UnityEngine;
using System.Collections;

public class TestUno : MonoBehaviour {

	public Texture2D Test1;
	public static Texture2D Test2;
	// Use this for initialization
	void Awake () {
		Test2 = Test1;
	}

}
