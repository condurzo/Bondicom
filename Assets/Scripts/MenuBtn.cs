using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MenuBtn : MonoBehaviour {
	public GameObject MenuGO;
	public bool states;
	public GameObject[] BotonesMenu;
	public GameObject SalirCartel;
	public GameObject BlockSalir;
	public GameObject MenuGris;
	public GameObject BtnOpen;
	public GameObject BtnClose;
	public GameObject Blockeador;
	public GameObject CartelDatos;

	public GameObject Interno1,Interno2,Interno3,Interno4;
	public GameObject Cartel1,Cartel2,Cartel3,Cartel4;
	public GameObject Arribo1,Arribo2,Arribo3,Arribo4;
	public GameObject Destino1,Destino2,Destino3,Destino4;

	public OnlineMaps Mapa;
	//<uses-sdk android:minSdkVersion="9" android:targetSdkVersion="24" />

	public void OpenMenu () {
		Blockeador.SetActive (true);
		iTween.MoveTo (MenuGO, iTween.Hash ("x", 0.8f ,"time", .4, "loopType", "none"
			, "delay", 0, "easeType", "easeInOutQuad"));
		MenuGris.SetActive (true);
		BtnOpen.SetActive (false);
		BtnClose.SetActive (true);
		Mapa.enabled = false;
	}
	public void CloseMenu(){
		Blockeador.SetActive (false);
		iTween.MoveTo (MenuGO, iTween.Hash ("x", 8, "time", .4, "loopType", "none"
			, "delay", 0, "easeType", "easeInOutQuad"));
		MenuGris.SetActive (false);
		BtnOpen.SetActive (true);
		BtnClose.SetActive (false);
		Mapa.enabled = true;
	}

	public void CancelarTodos(){
		BotonesMenu [0].SetActive (false);
		BotonesMenu [1].SetActive (false);
		BotonesMenu [2].SetActive (false);
		BotonesMenu [3].SetActive (false);
		BotonesMenu [4].SetActive (false);
		BotonesMenu [5].SetActive (false);
		BotonesMenu [6].SetActive (false);
		BotonesMenu [7].SetActive (false);
		BotonesMenu [8].SetActive (false);
		BotonesMenu [9].SetActive (false);
		BotonesMenu [10].SetActive (false);
		BotonesMenu [11].SetActive (false);
		BotonesMenu [12].SetActive (false);
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SalirBtn ();
		}

		if (Activacion.activarCartel) {
			CartelDatos.SetActive (true);
			Activacion.activarCartel = false;
		}
		if (Activacion.desactivoCartel) {
			CartelDatos.SetActive (false);
			Activacion.desactivoCartel = false;
		}
//		if (Activacion.activoDatosCartel) {
//			Interno1.SetActive (true);
//			Cartel1.SetActive (true);
//			Arribo1.SetActive (true);
//			Destino1.SetActive (true);
//			Interno2.SetActive (true);
//			Cartel2.SetActive (true);	
//			Arribo2.SetActive (true);
//			Destino2.SetActive (true);
//			Cartel3.SetActive (true);		
//			Interno3.SetActive (true);
//			Arribo3.SetActive (true);	
//			Destino3.SetActive (true);	
//			Cartel4.SetActive (true);
//			Interno4.SetActive (true);
//			Arribo4.SetActive (true);
//			Destino4.SetActive (true);
//			Activacion.activoDatosCartel = false;
//		}
//		if (Activacion.desactivoDatosCartel) {
//			Interno1.SetActive (false);
//			Cartel1.SetActive (false);
//			Arribo1.SetActive (false);
//			Destino1.SetActive (false);
//			Interno2.SetActive (false);
//			Cartel2.SetActive (false);	
//			Arribo2.SetActive (false);
//			Destino2.SetActive (false);
//			Cartel3.SetActive (false);		
//			Interno3.SetActive (false);
//			Arribo3.SetActive (false);	
//			Destino3.SetActive (false);	
//			Cartel4.SetActive (false);
//			Interno4.SetActive (false);
//			Arribo4.SetActive (false);
//			Destino4.SetActive (false);
//			Activacion.desactivoDatosCartel = false;
//		}
	}
	public void SalirBtn(){
		SalirCartel.SetActive (true);
		BlockSalir.SetActive (true);
	}

	public void ExitApp(){
		Application.Quit ();
	}

	public void CancelExit(){
		SalirCartel.SetActive (false);
		BlockSalir.SetActive (false);
	}
		

	public void FacebookBtn(){
		Application.OpenURL ("https://www.facebook.com/nextbondi");
	}
	public void TwitterBtn(){
		Application.OpenURL ("https://twitter.com/nextbondi");
	}
	public void EntroQuienes(){
		Mapa.enabled = false;
	}
}
