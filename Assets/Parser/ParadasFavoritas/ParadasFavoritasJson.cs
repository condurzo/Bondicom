using UnityEngine;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ParadasFavoritasJson : MonoBehaviour {
	public List<string> ParadasFav = new List<string>();
	public int ContadorListado;
	public string TempPPO, TempPP1, TempPP2, TempPP3, TempPP4, TempPP5, TempNew;
	public string NEWPPTEXT;
	public bool activo;
	public Text Texto0, Texto1, Texto2, Texto3, Texto4, Texto5;
	public int ID0, ID1, ID2, ID3, ID4, ID5, IDNEW;
	public int IDPara0, IDPara1, IDPara2, IDPara3, IDPara4, IDPara5, IDParaNEW;
	public float LatFav0,LatFav1,LatFav2,LatFav3,LatFav4,LatFav5,LatFavNew;
	public float LongFav0, LongFav1, LongFav2, LongFav3, LongFav4, LongFav5, LongFavNew;



	void Start(){
		//Reseteador ();
		ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
		Restablecer ();
	}


	public void EntroFavoritos(){
		PrediccionJson.ActivadorJson = true;
		OnlineMapsControlBase3D.instance.RemoveAllMarker3D ();
		Mapas.RemoveAllMarkers ();
		InternoLista.Clear ();
		CartelLista.Clear ();
		ArriboLista.Clear ();
		DestinoLista.Clear ();
		LatitudesColectivos.Clear ();
		LongitudesColectivos.Clear ();

		Interno1.text = "";	
		Cartel1.text = "";
		Arribo1.text = "";
		Destino1.text = "";
		Interno2.text = "";	
		Cartel2.text = "";		
		Arribo2.text = "";		
		Destino2.text = "";	
		Cartel3.text = "";		
		Interno3.text = "";	
		Arribo3.text = "";		
		Destino3.text = "";	
		Cartel4.text = "";
		Interno4.text = "";
		Arribo4.text = "";
		Destino4.text = "";

	}

	void Reseteador(){
		PlayerPrefs.SetString ("PPL0", "");
		PlayerPrefs.SetString ("PPL1", "");
		PlayerPrefs.SetString ("PPL2", "");
		PlayerPrefs.SetString ("PPL3", "");
		PlayerPrefs.SetString ("PPL4", "");
		PlayerPrefs.SetString ("PPL5", "");
		PlayerPrefs.SetString ("NewPP", "");
		PlayerPrefs.SetInt ("ContadorListado",0);
		PlayerPrefs.SetInt ("IDLineaFav0", 0);
		PlayerPrefs.SetInt ("IDLineaFav1", 0);
		PlayerPrefs.SetInt ("IDLineaFav2", 0);
		PlayerPrefs.SetInt ("IDLineaFav3", 0);
		PlayerPrefs.SetInt ("IDLineaFav4", 0);
		PlayerPrefs.SetInt ("IDLineaFav5", 0);
		PlayerPrefs.SetInt ("IDLineaFavNew",0);
		PlayerPrefs.SetInt ("IdParadaFav0",0);
		PlayerPrefs.SetInt ("IdParadaFav1",0);
		PlayerPrefs.SetInt ("IdParadaFav2",0);
		PlayerPrefs.SetInt ("IdParadaFav3",0);
		PlayerPrefs.SetInt ("IdParadaFav4",0);
		PlayerPrefs.SetInt ("IdParadaFav5",0);
		PlayerPrefs.SetInt ("IdParadaFavNew",0);

	}
	public void RefrescarListado () {
		if (!activo) {
			if (ContadorListado >= 6) {
				ParadasFav.Clear ();
				PlayerPrefs.SetString ("PPL0", TempNew);
				PlayerPrefs.SetString ("PPL1", TempPPO);
				PlayerPrefs.SetString ("PPL2", TempPP1);
				PlayerPrefs.SetString ("PPL3", TempPP2);
				PlayerPrefs.SetString ("PPL4", TempPP3);
				PlayerPrefs.SetString ("PPL5", TempPP4);
				ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
				ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));			
				ParadasFav.Add (PlayerPrefs.GetString ("PPL2"));
				ParadasFav.Add (PlayerPrefs.GetString ("PPL3"));
				ParadasFav.Add (PlayerPrefs.GetString ("PPL4"));
				ParadasFav.Add (PlayerPrefs.GetString ("PPL5"));
				activo = true;
			}
		}
	}

	public void Restablecer(){
		if (ContadorListado == 1) {
			ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
			Texto0.text = ParadasFav [0];
		}
		if (ContadorListado == 2) {
			Debug.Log ("ACAAAAA");
			ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));			
			Texto0.text = ParadasFav [0];
			Texto1.text = ParadasFav [1];
		}
		if (ContadorListado == 3) {
			ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));			
			ParadasFav.Add (PlayerPrefs.GetString ("PPL2"));
			Texto0.text = ParadasFav [0];
			Texto1.text = ParadasFav [1];
			Texto2.text = ParadasFav [2];
		}
		if (ContadorListado == 4) {
			ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));			
			ParadasFav.Add (PlayerPrefs.GetString ("PPL2"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL3"));
			Texto0.text = ParadasFav [0];
			Texto1.text = ParadasFav [1];
			Texto2.text = ParadasFav [2];
			Texto3.text = ParadasFav [3];
		}
		if (ContadorListado == 5) {
			ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));			
			ParadasFav.Add (PlayerPrefs.GetString ("PPL2"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL3"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL4"));
			Texto0.text = ParadasFav [0];
			Texto1.text = ParadasFav [1];
			Texto2.text = ParadasFav [2];
			Texto3.text = ParadasFav [3];
			Texto4.text = ParadasFav [4];
		}
		if (ContadorListado == 6) {
			ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));			
			ParadasFav.Add (PlayerPrefs.GetString ("PPL2"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL3"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL4"));
			ParadasFav.Add (PlayerPrefs.GetString ("PPL5"));
			Texto0.text = ParadasFav [0];
			Texto1.text = ParadasFav [1];
			Texto2.text = ParadasFav [2];
			Texto3.text = ParadasFav [3];
			Texto4.text = ParadasFav [4];
			Texto5.text = ParadasFav [5];
		}

	}
	void Update () {
		TempPPO = PlayerPrefs.GetString ("PPL0");
		TempPP1 = PlayerPrefs.GetString ("PPL1");
		TempPP2 = PlayerPrefs.GetString ("PPL2");
		TempPP3 = PlayerPrefs.GetString ("PPL3");
		TempPP4 = PlayerPrefs.GetString ("PPL4");
		TempPP5 = PlayerPrefs.GetString ("PPL5");
		TempNew = PlayerPrefs.GetString ("NewPP");
		ID0 = PlayerPrefs.GetInt ("IDLineaFav0");
		ID1 = PlayerPrefs.GetInt ("IDLineaFav1");
		ID2 = PlayerPrefs.GetInt ("IDLineaFav2");
		ID3 = PlayerPrefs.GetInt ("IDLineaFav3");
		ID4 = PlayerPrefs.GetInt ("IDLineaFav4");
		ID5 = PlayerPrefs.GetInt ("IDLineaFav5");
		IDNEW = PlayerPrefs.GetInt ("IDLineaFavNew");
		IDPara0 = PlayerPrefs.GetInt ("IdParadaFav0");
		IDPara1 = PlayerPrefs.GetInt ("IdParadaFav1");
		IDPara2 = PlayerPrefs.GetInt ("IdParadaFav2");
		IDPara3 = PlayerPrefs.GetInt ("IdParadaFav3");
		IDPara4 = PlayerPrefs.GetInt ("IdParadaFav4");
		IDPara5 = PlayerPrefs.GetInt ("IdParadaFav5");
		IDParaNEW = PlayerPrefs.GetInt ("IdParadaFavNew");
		LatFav0 = PlayerPrefs.GetFloat ("LatitudFavorita0");
		LatFav1 = PlayerPrefs.GetFloat ("LatitudFavorita1");
		LatFav2 = PlayerPrefs.GetFloat ("LatitudFavorita2");
		LatFav3 = PlayerPrefs.GetFloat ("LatitudFavorita3");
		LatFav4 = PlayerPrefs.GetFloat ("LatitudFavorita4");
		LatFav5 = PlayerPrefs.GetFloat ("LatitudFavorita5");
		LatFavNew = PlayerPrefs.GetFloat ("LatitudTemp");
		LongFav0 = PlayerPrefs.GetFloat ("LongitudFavorita0");
		LongFav1 = PlayerPrefs.GetFloat ("LongitudFavorita1");
		LongFav2 = PlayerPrefs.GetFloat ("LongitudFavorita2");
		LongFav3 = PlayerPrefs.GetFloat ("LongitudFavorita3");
		LongFav4 = PlayerPrefs.GetFloat ("LongitudFavorita4");
		LongFav5 = PlayerPrefs.GetFloat ("LongitudFavorita5");
		LongFavNew = PlayerPrefs.GetFloat ("LongitudTemp");


		if (LineaJson.agregando1) {
			if (ContadorListado == 0) {
				ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
				Texto0.text = TempPPO;
				ID0 = PlayerPrefs.GetInt ("TempLineaId");
				PlayerPrefs.SetInt ("IDLineaFav0", ID0);
				IDPara0 = PlayerPrefs.GetInt ("TempParadaId");
				PlayerPrefs.SetInt ("IdParadaFav0", IDPara0);
				LatFav0 = PlayerPrefs.GetFloat ("LatitudTemp");
				PlayerPrefs.SetFloat ("LatitudFavorita0", LatFav0);
				LongFav0 = PlayerPrefs.GetFloat ("LongitudTemp");
				PlayerPrefs.SetFloat ("LongitudFavorita0", LongFav0);
				ContadorListado++;
				PlayerPrefs.SetInt ("ContadorListado",ContadorListado);
				LineaJson.agregando1 = false;
			}
			LineaJson.agregando1 = false;
		}
		if (LineaJson.agregando2) {
			if (ContadorListado == 1) {
				ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));
				Texto1.text = TempPP1;
				ID1 = PlayerPrefs.GetInt ("TempLineaId");
				PlayerPrefs.SetInt ("IDLineaFav1", ID1);
				IDPara1 = PlayerPrefs.GetInt ("TempParadaId");
				PlayerPrefs.SetInt ("IdParadaFav1", IDPara1);
				LatFav1 = PlayerPrefs.GetFloat ("LatitudTemp");
				PlayerPrefs.SetFloat ("LatitudFavorita1", LatFav1);
				LongFav1 = PlayerPrefs.GetFloat ("LongitudTemp");
				PlayerPrefs.SetFloat ("LongitudFavorita1", LongFav1);
				ContadorListado++;
				PlayerPrefs.SetInt ("ContadorListado",ContadorListado);
				LineaJson.agregando2 = false;
			}
			LineaJson.agregando2 = false;
		}
		if (LineaJson.agregando3) {
			if (ContadorListado == 2) {
				ParadasFav.Add (PlayerPrefs.GetString ("PPL2"));
				Texto2.text = TempPP2;
				ID2 = PlayerPrefs.GetInt ("TempLineaId");
				PlayerPrefs.SetInt ("IDLineaFav2", ID2);
				IDPara2 = PlayerPrefs.GetInt ("TempParadaId");
				PlayerPrefs.SetInt ("IdParadaFav2", IDPara2);
				LatFav2 = PlayerPrefs.GetFloat ("LatitudTemp");
				PlayerPrefs.SetFloat ("LatitudFavorita2", LatFav2);
				LongFav2 = PlayerPrefs.GetFloat ("LongitudTemp");
				PlayerPrefs.SetFloat ("LongitudFavorita2", LongFav2);
				ContadorListado++;
				PlayerPrefs.SetInt ("ContadorListado",ContadorListado);
				LineaJson.agregando3 = false;
			}
			LineaJson.agregando3 = false;
		}
		if (LineaJson.agregando4) {
			if (ContadorListado == 3) {
				ParadasFav.Add (PlayerPrefs.GetString ("PPL3"));
				Texto3.text = TempPP3;
				ID3 = PlayerPrefs.GetInt ("TempLineaId");
				PlayerPrefs.SetInt ("IDLineaFav3", ID3);
				IDPara3 = PlayerPrefs.GetInt ("TempParadaId");
				PlayerPrefs.SetInt ("IdParadaFav3", IDPara3);
				LatFav3 = PlayerPrefs.GetFloat ("LatitudTemp");
				PlayerPrefs.SetFloat ("LatitudFavorita3", LatFav3);
				LongFav3 = PlayerPrefs.GetFloat ("LongitudTemp");
				PlayerPrefs.SetFloat ("LongitudFavorita3", LongFav3);
				ContadorListado++;
				PlayerPrefs.SetInt ("ContadorListado",ContadorListado);
				LineaJson.agregando4 = false;
			}
			LineaJson.agregando4 = false;
		}
		if (LineaJson.agregando5) {
			if (ContadorListado == 4) {
				ParadasFav.Add (PlayerPrefs.GetString ("PPL4"));
				Texto4.text = TempPP4;
				ID4 = PlayerPrefs.GetInt ("TempLineaId");
				PlayerPrefs.SetInt ("IDLineaFav4", ID4);
				IDPara4 = PlayerPrefs.GetInt ("TempParadaId");
				PlayerPrefs.SetInt ("IdParadaFav4", IDPara4);
				LatFav4 = PlayerPrefs.GetFloat ("LatitudTemp");
				PlayerPrefs.SetFloat ("LatitudFavorita4", LatFav4);
				LongFav4 = PlayerPrefs.GetFloat ("LongitudTemp");
				PlayerPrefs.SetFloat ("LongitudFavorita4", LongFav4);
				ContadorListado++;
				PlayerPrefs.SetInt ("ContadorListado",ContadorListado);
				LineaJson.agregando5 = false;
			}
			LineaJson.agregando5 = false;
		}
		if (LineaJson.agregando6) {
			if (ContadorListado == 5) {
				ParadasFav.Add (PlayerPrefs.GetString ("PPL5"));
				Texto5.text = TempPP5;
				ID5 = PlayerPrefs.GetInt ("TempLineaId");
				PlayerPrefs.SetInt ("IDLineaFav5", ID5);
				IDPara5 = PlayerPrefs.GetInt ("TempParadaId");
				PlayerPrefs.SetInt ("IdParadaFav5", IDPara5);
				LatFav5 = PlayerPrefs.GetFloat ("LatitudTemp");
				PlayerPrefs.SetFloat ("LatitudFavorita5", LatFav5);
				LongFav5 = PlayerPrefs.GetFloat ("LongitudTemp");
				PlayerPrefs.SetFloat ("LongitudFavorita5", LongFav5);
				ContadorListado++;
				PlayerPrefs.SetInt ("ContadorListado",ContadorListado);
				LineaJson.agregando6 = false;
			}
			LineaJson.agregando6 = false;
		}

		if (LineaJson.agregandoNew) {
			if (ContadorListado >= 6) {
				ParadasFav.Clear ();
				//NOMBRES
				PlayerPrefs.SetString ("PPL0", TempNew);
				PlayerPrefs.SetString ("PPL1", TempPPO);
				PlayerPrefs.SetString ("PPL2", TempPP1);
				PlayerPrefs.SetString ("PPL3", TempPP2);
				PlayerPrefs.SetString ("PPL4", TempPP3);
				PlayerPrefs.SetString ("PPL5", TempPP4);
				ParadasFav.Add (PlayerPrefs.GetString ("PPL0"));
				ParadasFav.Add (PlayerPrefs.GetString ("PPL1"));			
				ParadasFav.Add (PlayerPrefs.GetString ("PPL2"));
				ParadasFav.Add (PlayerPrefs.GetString ("PPL3"));
				ParadasFav.Add (PlayerPrefs.GetString ("PPL4"));
				ParadasFav.Add (PlayerPrefs.GetString ("PPL5"));
				Texto0.text = ParadasFav [0];
				Texto1.text = ParadasFav [1];
				Texto2.text = ParadasFav [2];
				Texto3.text = ParadasFav [3];
				Texto4.text = ParadasFav [4];
				Texto5.text = ParadasFav [5];
				// ID LINEA
				IDNEW = PlayerPrefs.GetInt ("TempLineaId");
				PlayerPrefs.SetInt ("IDLineaFav0", IDNEW);
				PlayerPrefs.SetInt ("IDLineaFav1", ID0);
				PlayerPrefs.SetInt ("IDLineaFav2", ID1);
				PlayerPrefs.SetInt ("IDLineaFav3", ID2);
				PlayerPrefs.SetInt ("IDLineaFav4", ID3);
				PlayerPrefs.SetInt ("IDLineaFav5", ID4);
				// ID PARADA
				IDParaNEW = PlayerPrefs.GetInt ("TempParadaId");
				PlayerPrefs.SetInt ("IdParadaFav0", IDParaNEW);
				PlayerPrefs.SetInt ("IdParadaFav1", IDPara0);
				PlayerPrefs.SetInt ("IdParadaFav2", IDPara1);
				PlayerPrefs.SetInt ("IdParadaFav3", IDPara2);
				PlayerPrefs.SetInt ("IdParadaFav4", IDPara3);
				PlayerPrefs.SetInt ("IdParadaFav5", IDPara4);
				//Latitud
				LatFavNew = PlayerPrefs.GetFloat ("LatitudTemp");
				PlayerPrefs.SetFloat ("LatitudFavorita0", LatFavNew);
				PlayerPrefs.SetFloat ("LatitudFavorita1", LatFav0);
				PlayerPrefs.SetFloat ("LatitudFavorita2", LatFav1);
				PlayerPrefs.SetFloat ("LatitudFavorita3", LatFav2);
				PlayerPrefs.SetFloat ("LatitudFavorita4", LatFav3);
				PlayerPrefs.SetFloat ("LatitudFavorita5", LatFav4);
				//Longitud
				LongFavNew = PlayerPrefs.GetFloat ("LongitudTemp");
				PlayerPrefs.SetFloat ("LongitudFavorita0", LongFavNew);
				PlayerPrefs.SetFloat ("LongitudFavorita1", LongFav0);
				PlayerPrefs.SetFloat ("LongitudFavorita2", LongFav1);
				PlayerPrefs.SetFloat ("LongitudFavorita3", LongFav2);
				PlayerPrefs.SetFloat ("LongitudFavorita4", LongFav3);
				PlayerPrefs.SetFloat ("LongitudFavorita5", LongFav4);

				LineaJson.agregandoNew = false;
			}
		}
	}

	public void BotonFavoritos(int index){
		
		switch (index) {
		case 0:
			if (PlayerPrefs.GetInt ("Activo1") == 1) {
				idLinea = PlayerPrefs.GetInt ("IDLineaFav0");
				idParada = PlayerPrefs.GetInt ("IdParadaFav0");
				float LatTemp0 = PlayerPrefs.GetFloat ("LatitudFavorita0");
				float LongTemp0 = PlayerPrefs.GetFloat ("LongitudFavorita0");
				double LatPPtemp0 = (double)LatTemp0;
				double LonPPtemp0 = (double)LongTemp0;
				OnlineMaps.latitude = LatPPtemp0;
				OnlineMaps.longitude = LonPPtemp0;
				PokeParadaSwich (idLinea, LatTemp0, LongTemp0);
				Mapas.zoom = 16;
				Mapas.zoom = 15;
				CanvasFavoritas.GetComponent<CanvasGroup> ().alpha = 0;
				CanvasFavoritas.GetComponent<CanvasGroup> ().blocksRaycasts = false;
				CanvasFavoritas.GetComponent<CanvasGroup> ().interactable = false;
				Fondo.SetActive (false);
				Bloqueador.SetActive (false);
				StartCoroutine (InfoParada ());
			}
			break;
		case 1:
			if (PlayerPrefs.GetInt ("Activo2") == 1) {
				idLinea = PlayerPrefs.GetInt ("IDLineaFav1");
				idParada = PlayerPrefs.GetInt ("IdParadaFav1");
				float LatTemp1 = PlayerPrefs.GetFloat ("LatitudFavorita1");
				float LongTemp1 = PlayerPrefs.GetFloat ("LongitudFavorita1");
				double LatPPtemp1 = (double)LatTemp1;
				double LonPPtemp1 = (double)LongTemp1;
				OnlineMaps.latitude = LatPPtemp1;
				OnlineMaps.longitude = LonPPtemp1;
				PokeParadaSwich (idLinea, LatTemp1, LongTemp1);
				Mapas.zoom = 16;
				Mapas.zoom = 15;
				CanvasFavoritas.GetComponent<CanvasGroup> ().alpha = 0;
				CanvasFavoritas.GetComponent<CanvasGroup> ().blocksRaycasts = false;
				CanvasFavoritas.GetComponent<CanvasGroup> ().interactable = false;
				Fondo.SetActive (false);
				Bloqueador.SetActive (false);
				StartCoroutine (InfoParada ());
			}
			break;
		case 2:
			if (PlayerPrefs.GetInt ("Activo3") == 1) {
				idLinea = PlayerPrefs.GetInt ("IDLineaFav2");
				idParada = PlayerPrefs.GetInt ("IdParadaFav2");
				float LatTemp2 = PlayerPrefs.GetFloat ("LatitudFavorita2");
				float LongTemp2 = PlayerPrefs.GetFloat ("LongitudFavorita2");
				double LatPPtemp2 = (double)LatTemp2;
				double LonPPtemp2 = (double)LongTemp2;
				OnlineMaps.latitude = LatPPtemp2;
				OnlineMaps.longitude = LonPPtemp2;
				PokeParadaSwich (idLinea, LatTemp2, LongTemp2);
				Mapas.zoom = 16;
				Mapas.zoom = 15;
				CanvasFavoritas.GetComponent<CanvasGroup> ().alpha = 0;
				CanvasFavoritas.GetComponent<CanvasGroup> ().blocksRaycasts = false;
				CanvasFavoritas.GetComponent<CanvasGroup> ().interactable = false;
				Fondo.SetActive (false);
				Bloqueador.SetActive (false);
				StartCoroutine (InfoParada ());
			}
			break;
		case 3:
			if (PlayerPrefs.GetInt ("Activo4") == 1) {
				idLinea = PlayerPrefs.GetInt ("IDLineaFav3");
				idParada = PlayerPrefs.GetInt ("IdParadaFav3");
				float LatTemp3 = PlayerPrefs.GetFloat ("LatitudFavorita3");
				float LongTemp3 = PlayerPrefs.GetFloat ("LongitudFavorita3");
				double LatPPtemp3 = (double)LatTemp3;
				double LonPPtemp3 = (double)LongTemp3;
				OnlineMaps.latitude = LatPPtemp3;
				OnlineMaps.longitude = LonPPtemp3;
				PokeParadaSwich (idLinea, LatTemp3, LongTemp3);
				Mapas.zoom = 16;
				Mapas.zoom = 15;
				CanvasFavoritas.GetComponent<CanvasGroup> ().alpha = 0;
				CanvasFavoritas.GetComponent<CanvasGroup> ().blocksRaycasts = false;
				CanvasFavoritas.GetComponent<CanvasGroup> ().interactable = false;
				Fondo.SetActive (false);
				Bloqueador.SetActive (false);
				StartCoroutine (InfoParada ());
			}
			break;
		case 4:
			if (PlayerPrefs.GetInt ("Activo5") == 1) {
				idLinea = PlayerPrefs.GetInt ("IDLineaFav4");
				idParada = PlayerPrefs.GetInt ("IdParadaFav4");
				float LatTemp4 = PlayerPrefs.GetFloat ("LatitudFavorita4");
				float LongTemp4 = PlayerPrefs.GetFloat ("LongitudFavorita4");
				double LatPPtemp4 = (double)LatTemp4;
				double LonPPtemp4 = (double)LongTemp4;
				OnlineMaps.latitude = LatPPtemp4;
				OnlineMaps.longitude = LonPPtemp4;
				PokeParadaSwich (idLinea, LatTemp4, LongTemp4);
				Mapas.zoom = 16;
				Mapas.zoom = 15;
				CanvasFavoritas.GetComponent<CanvasGroup> ().alpha = 0;
				CanvasFavoritas.GetComponent<CanvasGroup> ().blocksRaycasts = false;
				CanvasFavoritas.GetComponent<CanvasGroup> ().interactable = false;
				Fondo.SetActive (false);
				Bloqueador.SetActive (false);
				StartCoroutine (InfoParada ());
			}
			break;
		case 5:
			if (PlayerPrefs.GetInt ("Activo6") == 1) {
				idLinea = PlayerPrefs.GetInt ("IDLineaFav5");
				idParada = PlayerPrefs.GetInt ("IdParadaFav5");
				float LatTemp5 = PlayerPrefs.GetFloat ("LatitudFavorita5");
				float LongTemp5 = PlayerPrefs.GetFloat ("LongitudFavorita5");
				double LatPPtemp5 = (double)LatTemp5;
				double LonPPtemp5 = (double)LongTemp5;
				OnlineMaps.latitude = LatPPtemp5;
				OnlineMaps.longitude = LonPPtemp5;
				PokeParadaSwich (idLinea, LatTemp5, LongTemp5);
				Mapas.zoom = 16;
				Mapas.zoom = 15;
				CanvasFavoritas.GetComponent<CanvasGroup> ().alpha = 0;
				CanvasFavoritas.GetComponent<CanvasGroup> ().blocksRaycasts = false;
				CanvasFavoritas.GetComponent<CanvasGroup> ().interactable = false;
				Fondo.SetActive (false);
				Bloqueador.SetActive (false);
				StartCoroutine (InfoParada ());
			}
			break;
		}
	}

	void PokeParadaSwich(int idLineaIndex, float LatPPTemp, float LongPPTemp){
		switch (idLineaIndex) {
		case 253:
			OnlineMapsControlBase3D.instance.AddMarker3D (new Vector2 (LongPPTemp, LatPPTemp), PPoke1);
			break;
		case 254:
			OnlineMapsControlBase3D.instance.AddMarker3D (new Vector2 (LongPPTemp, LatPPTemp), PPoke12);
			break;
		case 255:
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongPPTemp, LatPPTemp),PPoke39);
			break;
		case 306:
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongPPTemp, LatPPTemp),PPoke68);
			break;
		case 308:
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongPPTemp, LatPPTemp),PPoke102);
			break;
		case 315:
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongPPTemp, LatPPTemp),PPoke110);
			break;
		case 300:
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongPPTemp, LatPPTemp),PPoke126);
			break;
		case 244:
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongPPTemp, LatPPTemp),PPoke501);
			break;
		case 237:
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongPPTemp, LatPPTemp),PPoke503P);
			break;
		case 280:
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongPPTemp, LatPPTemp),PPokeCOR);
			break;
		case 318:
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongPPTemp, LatPPTemp),PPokeSPC);
			break;

		}
	}

	public int idParada;
	public int idLinea;
	public List<string> InternoLista = new List<string>();
	public List<string> CartelLista = new List<string>();
	public List<string> ArriboLista = new List<string>();
	public List<string> DestinoLista = new List<string>();
	public int TempArray;
	public List<float> LatitudesColectivos = new List<float>();
	public List<float> LongitudesColectivos = new List<float>();
	public float LatCole;
	public float LongCole;
	public Text Interno1,Interno2,Interno3,Interno4;
	public Text Cartel1,Cartel2,Cartel3,Cartel4;
	public Text Arribo1,Arribo2,Arribo3,Arribo4;
	public Text Destino1,Destino2,Destino3,Destino4;
	public OnlineMaps Mapas;
	public Texture2D Colectivo2D;
	public GameObject PPoke1, PPoke12, PPoke39, PPoke68, PPoke102, PPoke110, PPoke126, PPoke501, PPoke503P, PPokeCOR, PPokeSPC;
	public GameObject CanvasFavoritas;
	public GameObject Fondo;
	public GameObject Bloqueador;


	IEnumerator InfoParada(){
		string url = "http://www.bondicom.com.ar/responders/bondicomResponder.aspx?prediccionJson="+idParada+"&lineasJson="+idLinea;
		WWW www = new WWW(url);

		yield return www;
		if (www.error == null){
			Debug.Log("Parada" + www.data);

			ProcessPrediccion(www.data);
		}else{
			Debug.Log("ERROR: " + www.error);
		}

	}

	private void ProcessPrediccion(string jsonString){
		JsonData jsonPrediccion = JsonMapper.ToObject(jsonString);
		Prediccion prediccion;

		for(int i = 0; i<jsonPrediccion["Table"].Count; i++){	
			prediccion = new Prediccion();
			prediccion.cartel = jsonPrediccion["Table"][i]["cartel"].ToString();
			prediccion.dif = Convert.ToInt16(jsonPrediccion["Table"][i]["dif"].ToString());
			prediccion.fkd = Convert.ToInt16(jsonPrediccion["Table"][i]["fkd"].ToString());
			prediccion.fkm = Convert.ToInt16(jsonPrediccion["Table"][i]["fkm"].ToString());
			prediccion.fkruta = Convert.ToInt16(jsonPrediccion["Table"][i]["fkruta"].ToString());
			prediccion.hacia = jsonPrediccion["Table"][i]["hacia"].ToString();
			prediccion.i = Convert.ToInt16(jsonPrediccion["Table"][i]["i"].ToString());
			prediccion.lat = jsonPrediccion["Table"][i]["lat"].ToString();
			prediccion.lon = jsonPrediccion["Table"][i]["lon"].ToString();
			prediccion.p_lat = jsonPrediccion["Table"][i]["p_lat"].ToString();
			prediccion.p_lon = jsonPrediccion["Table"][i]["p_lon"].ToString();
			prediccion.rampa = Convert.ToInt16(jsonPrediccion["Table"][i]["rampa"].ToString());
			prediccion.seg = Convert.ToInt16(jsonPrediccion["Table"][i]["seg"].ToString());
			prediccion.t = jsonPrediccion["Table"][i]["t"].ToString();

			InternoLista.Add(prediccion.i.ToString());
			CartelLista.Add(prediccion.cartel.ToString());
			ArriboLista.Add(prediccion.t.ToString());
			DestinoLista.Add(prediccion.hacia.ToString());
			TempArray = i;

			LatCole = float.Parse(prediccion.lat);
			LongCole = float.Parse(prediccion.lon);
			LatitudesColectivos.Add (LatCole);
			LongitudesColectivos.Add (LongCole);

		}
		if (TempArray >= 0) {
			Interno1.text = InternoLista [0];	
			Cartel1.text = CartelLista [0];
			Arribo1.text = ArriboLista [0];
			Destino1.text = DestinoLista [0];
			string TempDatos = InternoLista [0] + " - :" + ArriboLista [0] + " a " + DestinoLista [0];
			Mapas.AddMarker (new Vector2 (LongitudesColectivos [0], LatitudesColectivos [0]), Colectivo2D, TempDatos);
		}
		if (TempArray >= 1) {
			Interno2.text = InternoLista [1];	
			Cartel2.text = CartelLista [1];		
			Arribo2.text = ArriboLista [1];		
			Destino2.text = DestinoLista [1];
			string TempDatos = InternoLista [1] + " - :" + ArriboLista [1] + " a " + DestinoLista [1];
			Mapas.AddMarker (new Vector2 (LongitudesColectivos [1], LatitudesColectivos [1]), Colectivo2D, TempDatos);
		}
		if (TempArray >= 2) {
			Cartel3.text = CartelLista [2];		
			Interno3.text = InternoLista [2];	
			Arribo3.text = ArriboLista [2];		
			Destino3.text = DestinoLista [2];
			string TempDatos = InternoLista [2] + " - :" + ArriboLista [2] + " a " + DestinoLista [2];
			Mapas.AddMarker (new Vector2 (LongitudesColectivos [2], LatitudesColectivos [2]), Colectivo2D, TempDatos);
		}
		if (TempArray >= 3) {
			Cartel4.text = CartelLista [3];
			Interno4.text = InternoLista [3];
			Arribo4.text = ArriboLista [3];
			Destino4.text = DestinoLista [3];
			string TempDatos = InternoLista [3] + " - :" + ArriboLista [3] + " a " + DestinoLista [3];
			Mapas.AddMarker (new Vector2 (LongitudesColectivos [3], LatitudesColectivos [3]), Colectivo2D, TempDatos);
		}

		Mapas.zoom = 16;
		Mapas.zoom = 15;

	}
}
