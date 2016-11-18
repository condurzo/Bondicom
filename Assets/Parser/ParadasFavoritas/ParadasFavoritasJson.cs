using UnityEngine;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ParadasFavoritasJson : MonoBehaviour {
	public List<string> ParadasFav = new List<string>();
	public int ContadorListado;
	public string TempPPO, TempPP1, TempPP2, TempPP3, TempNew;
	public string NEWPPTEXT;
	public bool activo;

//	void Start(){
//		PlayerPrefs.SetString ("PPL0", "");
//		PlayerPrefs.SetString ("PPL1", "");
//		PlayerPrefs.SetString ("PPL2", "");
//		PlayerPrefs.SetString ("PPL3", "");
//		PlayerPrefs.SetString ("NewPP", "");
//	}


	public void RefrescarListado () {
		if (!activo) {
			if (ContadorListado == 4) {
				//ParadasFav.RemoveAt (3);
				ParadasFav.Clear ();
				PlayerPrefs.SetString ("PPL0", TempNew);
				PlayerPrefs.SetString ("PPL1", TempPPO);
				PlayerPrefs.SetString ("PPL2", TempPP1);
				PlayerPrefs.SetString ("PPL3", TempPP2);
				//ParadasFav.Add (PlayerPrefs.GetString ("NewPP"));
				ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
				ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));			
				ParadasFav.Add (PlayerPrefs.GetString ("PPL2"));
				ParadasFav.Add (PlayerPrefs.GetString ("PPL3"));
				activo = true;
			}
		}
	}


	public void Agregar(){
		if (ContadorListado == 0) {
			PlayerPrefs.SetString ("PPL0", "CERO");
			ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
			ContadorListado++;

		}
		if (ContadorListado == 1) {
			PlayerPrefs.SetString ("PPL1", "UNO");
			ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));
			ContadorListado++;
		}
		if (ContadorListado == 2) {
			PlayerPrefs.SetString ("PPL2", "DOS");
			ParadasFav.Add (PlayerPrefs.GetString ("PPL2"));
			ContadorListado++;
		}
		if (ContadorListado == 3) {
			PlayerPrefs.SetString ("PPL3", "TRES");
			ParadasFav.Add (PlayerPrefs.GetString ("PPL3"));
			ContadorListado++;
		}
		if (ContadorListado == 4) {
			PlayerPrefs.SetString ("NewPP", "NEW");
		}
	}

	public void Restablecer(){
		if (ContadorListado == 0) {
			ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
		}
		if (ContadorListado == 1) {
			ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));
		}
		if (ContadorListado == 2) {
			ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));			
			ParadasFav.Add (PlayerPrefs.GetString ("PPL2"));
		}
		if (ContadorListado == 3) {
			ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));			
			ParadasFav.Add (PlayerPrefs.GetString ("PPL2"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL3"));
		}
	}
	// Update is called once per frame
	void Update () {
		TempPPO = PlayerPrefs.GetString ("PPL0");
		TempPP1 = PlayerPrefs.GetString ("PPL1");
		TempPP2 = PlayerPrefs.GetString ("PPL2");
		TempPP3 = PlayerPrefs.GetString ("PPL3");
		TempNew = PlayerPrefs.GetString ("NewPP");
		//ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
	}

	public void RandomPP(){
		PlayerPrefs.SetString ("NewPP", NEWPPTEXT);
		activo = false;
	}

}
