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

	void Start(){
		Camara1 = GameObject.Find ("Main Camera");
		scrollMap = GameObject.Find ("Map plane");

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
		iTween.RotateBy(Circulo, iTween.Hash(
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
