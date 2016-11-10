using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MenuBtn : MonoBehaviour {
	public GameObject MenuGO;
	public bool states;
	public GameObject[] BotonesMenu;
	public GameObject SalirCartel;
	public GameObject MenuGris;
	public GameObject BtnOpen;
	public GameObject BtnClose;
	public GameObject Blockeador;
	//<uses-sdk android:minSdkVersion="9" android:targetSdkVersion="24" />

	public void OpenMenu () {
		Blockeador.SetActive (true);
		iTween.MoveTo (MenuGO, iTween.Hash ("x", -0.5f ,"time", .4, "loopType", "none"
			, "delay", 0, "easeType", "easeInOutQuad"));
		MenuGris.SetActive (true);
		BtnOpen.SetActive (false);
		BtnClose.SetActive (true);
	}
	public void CloseMenu(){
		Blockeador.SetActive (false);
		iTween.MoveTo (MenuGO, iTween.Hash ("x", -8, "time", .4, "loopType", "none"
			, "delay", 0, "easeType", "easeInOutQuad"));
		MenuGris.SetActive (false);
		BtnOpen.SetActive (true);
		BtnClose.SetActive (false);
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
			SalirCartel.SetActive (true);
		}
	}

	public void ExitApp(){
		Application.Quit ();
	}

}
