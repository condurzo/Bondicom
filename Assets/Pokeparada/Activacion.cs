using UnityEngine;
using System.Collections;

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

	public static bool label0, label1, label2, label3, label4, label5, label6, label7, label8, label9,
					label10,label11,label12,label13,label14,label15,label16,label17,label18,label19;

	public delegate void ClickAction(OnlineMapsMarkerBase marker);
	public static event ClickAction markerClickedEvent;


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

	void OnMouseDown()
	{

		if (OnlineMapsControlBase3D.instance.markers3D [0].label == "0") {
			Debug.Log ("Toco 00");
			label0 = true;
		}
		if (OnlineMapsControlBase3D.instance.markers3D [1].label == "1") {
			Debug.Log ("Toco 11");
			label1 = true;
		}
		if (OnlineMapsControlBase3D.instance.markers3D [2].label == "2") {
			Debug.Log ("Toco 22");
			label2 = true;
		}
		if (OnlineMapsControlBase3D.instance.markers3D [3].label == "3") {
			Debug.Log ("Toco 33");
			label3 = true;
		}
		Debug.Log("Click!");
	}
	void BooleanosFalse(){
		label0 = false;
		label1 = false;
		label2 = false;
		label3 = false;
		label4 = false;
		label5 = false;
		label6 = false;
		label7 = false;
		label8 = false;
		label9 = false;
		label10 = false;
		label11 = false;
		label12 = false;
		label13 = false;
		label14 = false;
		label15 = false;
		label16 = false;
		label17 = false;
		label18 = false;
		label19 = false;
	}


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

		if (OnlineMapsControlBase3D.instance.markers3D [0].label == "0") {
			Debug.Log ("Toco 00");
			label0 = true;
		}
		if (OnlineMapsControlBase3D.instance.markers3D [1].label == "1") {
			Debug.Log ("Toco 11");
			label1 = true;
		}
		if (OnlineMapsControlBase3D.instance.markers3D [2].label == "2") {
			Debug.Log ("Toco 22");
			label2 = true;
		}
		if (OnlineMapsControlBase3D.instance.markers3D [3].label == "3") {
			Debug.Log ("Toco 33");
			label3 = true;
		}
//		if (OnlineMapsControlBase3D.instance.markers3D [4].label == "4") {
//			Debug.Log ("Toco 44");
//			label4 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [5].label == "5") {
//			Debug.Log ("Toco 55");
//			label5 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [6].label == "6") {
//			BooleanosFalse ();
//			label6 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [7].label == "7") {
//			BooleanosFalse ();
//			label7 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [8].label == "8") {
//			BooleanosFalse ();
//			label8 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [9].label == "9") {
//			BooleanosFalse ();
//			label9= true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [10].label == "10") {
//			BooleanosFalse ();
//			label10 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [11].label == "11") {
//			BooleanosFalse ();
//			label11 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [12].label == "12") {
//			BooleanosFalse ();
//			label12 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [13].label == "13") {
//			BooleanosFalse ();
//			label13 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [14].label == "14") {
//			BooleanosFalse ();
//			label14 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [15].label == "15") {
//			BooleanosFalse ();
//			label15 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [16].label == "16") {
//			BooleanosFalse ();
//			label16 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [17].label == "17") {
//			BooleanosFalse ();
//			label17 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [18].label == "18") {
//			BooleanosFalse ();
//			label18 = true;
//		}
//		if (OnlineMapsControlBase3D.instance.markers3D [19].label == "19") {
//			BooleanosFalse ();
//			label19 = true;
//		}
			
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
	}

}
