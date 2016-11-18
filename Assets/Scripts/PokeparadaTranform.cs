using UnityEngine;
using System.Collections;

public class PokeparadaTranform : MonoBehaviour {
	public bool activo;
	public static int idPP;
	public int TempId;
	public string TempString;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (!activo) {
			this.transform.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
			//this.transform.transform.localPosition = new Vector3 (0f, 0f, 0f);
			//this.gameObject.SetActive (true);
			activo = true;
		}
		//
	}
}
