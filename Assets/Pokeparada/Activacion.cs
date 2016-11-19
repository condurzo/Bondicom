using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Activacion : MonoBehaviour {

	public GameObject Camara1;
	public GameObject Camara2;
	public GameObject CirculoGrande;
	public GameObject Circulo;
	public GameObject BtnObject;
	public BoxCollider CollBtn;

	public static bool Girar;

	public RotateSample Rota1;
	public RotateSample1 Rota2;

	public GameObject CerrarBtn;

	public static bool Activado;

	public GameObject scrollMap;

	public float ContadorGirando;
	public bool Girando;
	public static bool activarCartel;
	public static bool desactivoCartel;
	public static bool activoDatosCartel;
	public static bool desactivoDatosCartel;

	public OnlineMaps Mapas;

	public delegate void ClickAction(OnlineMapsMarkerBase marker);
	public static event ClickAction markerClickedEvent;

	public int id=0;

	public static bool idPP0,idPP1,idPP2,idPP3,idPP4,idPP5,idPP6,idPP7,idPP8,idPP9,idPP10,idPP11,idPP12,idPP13,
						idPP14,idPP15,idPP16,idPP17,idPP18,idPP19,vaciarTodos;

	void Start(){

		Camara1 = GameObject.Find ("Main Camera");
		scrollMap = GameObject.Find ("Map plane");

//		OnlineMapsControlBase3D api = OnlineMapsControlBase3D.instance;
//		foreach (var marker in api.markers3D) {
//			marker.OnClick += OnMarkerClick;
//
//			Debug.LogFormat ("Marker {0} found", marker.label);
//		}

	}


//	private void OnMarkerClick (OnlineMapsMarkerBase marker) 
//	{
//		Debug.Log(marker.label);
//	
//
//		if(markerClickedEvent != null)
//			markerClickedEvent(marker);
//	}





	void TocoBtn () {
		activarCartel = true;
		iTween.Stop (CirculoGrande);
		iTween.Stop (Circulo);
		CirculoGrande.transform.eulerAngles = new Vector3 (-34, 0, 0);
		Circulo.transform.eulerAngles = new Vector3 (0, 90, -34);
		Camara2.SetActive (true);
		BtnObject.GetComponent<tk2dButton> ().enabled = false;
		CollBtn.enabled = false;
		CerrarBtn.SetActive (true);
		Activado = true;
		scrollMap.GetComponent<OnlineMapsTextureControl> ().enabled = false;

		if (!PrediccionJson.ActivadorJson) {
			if (id == 0) {
				idPP0 = true;
				Debug.Log ("id" + id);
			}
			if (id == 1) {
				idPP1 = true;
				Debug.Log ("id" + id);
			}
			if (id == 2) {
				idPP2 = true;
				Debug.Log ("id" + id);
			}
			if (id == 3) {
				idPP3 = true;
				Debug.Log ("id" + id);
			}
			if (id == 4) {
				idPP4 = true;
				Debug.Log ("id" + id);
			}
			if (id == 5) {
				idPP5 = true;
				Debug.Log ("id" + id);
			}
			if (id == 6) {
				idPP6 = true;
				Debug.Log ("id" + id);
			}
			if (id == 7) {
				idPP7 = true;
				Debug.Log ("id" + id);
			}
			if (id == 8) {
				idPP8 = true;
				Debug.Log ("id" + id);
			}
			if (id == 9) {
				idPP9 = true;
				Debug.Log ("id" + id);
			}
			if (id == 10) {
				idPP10 = true;
				Debug.Log ("id" + id);
			}
			if (id == 11) {
				idPP11 = true;
				Debug.Log ("id" + id);
			}
			if (id == 12) {
				idPP12 = true;
				Debug.Log ("id" + id);
			}
			if (id == 13) {
				idPP13 = true;
				Debug.Log ("id" + id);
			}
			if (id == 14) {
				idPP14 = true;
				Debug.Log ("id" + id);
			}
			if (id == 15) {
				idPP15 = true;
				Debug.Log ("id" + id);
			}
			if (id == 16) {
				idPP16 = true;
				Debug.Log ("id" + id);
			}
			if (id == 17) {
				idPP17 = true;
				Debug.Log ("id" + id);
			}
			if (id == 18) {
				idPP18 = true;
				Debug.Log ("id" + id);
			}
			if (id == 19) {
				idPP19 = true;
				Debug.Log ("id" + id);
			}
		}
	}

	void Update(){
		if (Activado) {
			if (Girar) {
				Invoke ("Giro", 0.1f);
				Girar = false;
			}
		}
		if (Girando) {
			ContadorGirando += Time.deltaTime;
			if (ContadorGirando >= 3.2f) {
				activoDatosCartel = true;
				ContadorGirando = 0;
				Girando = false;
			}
		}
	}

	void Giro(){
		Girando = true;
		iTween.RotateBy(this.Circulo, iTween.Hash(
			"y", 1000.0f, 
			"time", 3f,
			"easetype", "linear",
			"none", iTween.LoopType.loop
		));
	}

	void Close(){
		ContadorGirando = 0;
		Girando = false;
		activarCartel = false;
		activoDatosCartel = false;
		desactivoDatosCartel = true;
		desactivoCartel = true;
		Camara1.SetActive (true);
		Camara2.SetActive (false);
		CerrarBtn.SetActive(false);
		Rota1.Start ();
		Rota2.Start ();
		BtnObject.GetComponent<tk2dButton>().enabled = true;
		CollBtn.enabled = true;
		Activado = false;
		scrollMap.GetComponent<OnlineMapsTextureControl> ().enabled = true;
		vaciarTodos = true;
	}

}
