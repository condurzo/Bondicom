﻿using UnityEngine;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class LineaJson : MonoBehaviour
{
	public Dropdown Maindropdown;
	public Toggle itemBase;
	public Text	text;
	public List<string> Lineas = new List<string>();
	public int idLinea;

	public Dropdown MaindropdownParadas;
	public List<string> Paradas = new List<string>();
	public int idParada;
	public List<GameObject> ParadasLista = new List<GameObject>();
	public GameObject Recuadro;

	public List<string> InternoLista = new List<string>();
	public List<string> CartelLista = new List<string>();
	public List<string> ArriboLista = new List<string>();
	public List<string> DestinoLista = new List<string>();
	public List<double> Latitudes = new List<double>();
	public List<double> Longitudes = new List<double>();
	public string Latitud;
	public string Longitud;
	public double Lati;
	public double Longi;
	public GameObject Fondo;
	public GameObject Fondo2;
	public GameObject Barra;
	public GameObject FondoNegro;
	public GameObject Cartel;
	public GameObject ListaParadaGO;
	public Text Interno1,Interno2,Interno3,Interno4;
	public Text Cartel1,Cartel2,Cartel3,Cartel4;
	public Text Arribo1,Arribo2,Arribo3,Arribo4;
	public Text Destino1,Destino2,Destino3,Destino4;
	public OnlineMaps Mapas;
	public OnlineMapsMarker3DInstance Control3D;
	public GameObject PrefabPoke;
	public static bool Test01;
	public static bool HayUno;
	public static bool Test02;
	public GameObject BlockeadorParadas;

#region LINEA
	IEnumerator Start(){
		
		Lineas.Add ("0");
		//Paradas.Add ("0");
//		Maindropdown.onValueChanged.AddListener(delegate {
//			myDropdownValueChangedHandler(Maindropdown);
//		});
//		MaindropdownParadas.onValueChanged.AddListener(delegate {
//			myDropdownValueChangedHandlerParada(MaindropdownParadas);
//		});

		string url = "http://www.bondicom.com.ar/responders/bondicomResponder.aspx?blineasJson=255";
		WWW www = new WWW(url);

		yield return www;
		if (www.error == null){
			Debug.Log("Linea" + www.data);
			ProcessLineas(www.data);
		}else{
			Debug.Log("ERROR: " + www.error);
		}
	}

	private void ProcessLineas(string jsonString){
		JsonData jsonLineas = JsonMapper.ToObject(jsonString);
		Linea linea;

		for(int i = 0; i<jsonLineas["row"].Count; i++){	
			linea = new Linea();
			linea.abrev = jsonLineas["row"][i]["abrev"].ToString();
			linea.ds = jsonLineas["row"][i]["ds"].ToString();
			linea.id = Convert.ToInt16(jsonLineas["row"][i]["id"].ToString());
			linea.proximamente = Convert.ToInt16(jsonLineas["row"][i]["proximamente"].ToString());
			linea.usarReco = Convert.ToInt16(jsonLineas["row"][i]["usarReco"].ToString());

			Maindropdown.options.Add (new Dropdown.OptionData() {text=linea.ds});
			Lineas.Add(linea.id.ToString());
		}
	}

	public void Linea1Btn(){
		BlockeadorParadas.SetActive (true);
		if (HayUno) {
			Test02 = true;
			HayUno = false;
		}
		idLinea = 253;
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		foreach (GameObject listaPa in ParadasLista) {
			listaPa.SetActive (false);	
		}
		Barra.SetActive (true);
		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 1;
		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = true;
		StartCoroutine (ParadasRutina ());
	}
	public void Linea12Btn(){
		BlockeadorParadas.SetActive (true);
		if (HayUno) {
			Test02 = true;
			HayUno = false;
		}
		idLinea = 254;
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		foreach (GameObject listaPa in ParadasLista) {
			listaPa.SetActive (false);	
		}
		Barra.SetActive (true);
		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 1;
		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = true;
		StartCoroutine (ParadasRutina ());
	}
	public void Linea39Btn(){
		BlockeadorParadas.SetActive (true);
		if (HayUno) {
			Test02 = true;
			HayUno = false;
		}
		idLinea = 255;
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		foreach (GameObject listaPa in ParadasLista) {
			listaPa.SetActive (false);	
		}
		Barra.SetActive (true);
		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 1;
		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = true;
		StartCoroutine (ParadasRutina ());
	}
	public void Linea68Btn(){
		BlockeadorParadas.SetActive (true);
		if (HayUno) {
			Test02 = true;
			HayUno = false;
		}
		idLinea = 306;
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		foreach (GameObject listaPa in ParadasLista) {
			listaPa.SetActive (false);	
		}
		Barra.SetActive (true);
		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 1;
		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = true;
		StartCoroutine (ParadasRutina ());
	}
	public void Linea102Btn(){
		BlockeadorParadas.SetActive (true);
		if (HayUno) {
			Test02 = true;
			HayUno = false;
		}
		idLinea = 308;
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		foreach (GameObject listaPa in ParadasLista) {
			listaPa.SetActive (false);	
		}
		Barra.SetActive (true);
		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 1;
		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = true;
		StartCoroutine (ParadasRutina ());
	}
	public void Linea110Btn(){
		BlockeadorParadas.SetActive (true);
		if (HayUno) {
			Test02 = true;
			HayUno = false;
		}
		idLinea = 315;
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		foreach (GameObject listaPa in ParadasLista) {
			listaPa.SetActive (false);	
		}
		Barra.SetActive (true);
		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 1;
		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = true;
		StartCoroutine (ParadasRutina ());
	}
	public void Linea126Btn(){
		BlockeadorParadas.SetActive (true);
		if (HayUno) {
			Test02 = true;
			HayUno = false;
		}
		idLinea = 300;
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		foreach (GameObject listaPa in ParadasLista) {
			listaPa.SetActive (false);	
		}
		Barra.SetActive (true);
		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 1;
		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = true;
		StartCoroutine (ParadasRutina ());
	}
	public void Linea501Btn(){
		BlockeadorParadas.SetActive (true);
		if (HayUno) {
			Test02 = true;
			HayUno = false;
		}
		idLinea = 244;
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		foreach (GameObject listaPa in ParadasLista) {
			listaPa.SetActive (false);	
		}
		Barra.SetActive (true);
		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 1;
		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = true;
		StartCoroutine (ParadasRutina ());
	}
	public void Linea503PBtn(){
		//BlockeadorParadas.SetActive (true);
//		if (HayUno) {
//			Test02 = true;
//			HayUno = false;
//		}
//		idLinea = 237;
		//		Paradas.Clear ();
		//Latitudes.Clear ();
		//Longitudes.Clear ();
//		foreach (GameObject listaPa in ParadasLista) {
//			listaPa.SetActive (false);	
		//		}
		//Barra.SetActive (true);
//		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 1;
//		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = true;
//		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = true;
//		StartCoroutine (ParadasRutina ());
	}
	public void LineaCORBtn(){
		BlockeadorParadas.SetActive (true);
		if (HayUno) {
			Test02 = true;
			HayUno = false;
		}
		idLinea = 280;
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		foreach (GameObject listaPa in ParadasLista) {
			listaPa.SetActive (false);	
		}
		Barra.SetActive (true);
		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 1;
		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = true;
		StartCoroutine (ParadasRutina ());
	}
	public void LineaSPCBtn(){
		BlockeadorParadas.SetActive (true);
		if (HayUno) {
			Test02 = true;
			HayUno = false;
		}
		idLinea = 318;
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		foreach (GameObject listaPa in ParadasLista) {
			listaPa.SetActive (false);	
		}
		Barra.SetActive (true);
		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 1;
		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = true;
		StartCoroutine (ParadasRutina ());
	}
//	private void myDropdownValueChangedHandler(Dropdown target) {
//		idLinea = int.Parse(Lineas [target.value]);
//		MaindropdownParadas.ClearOptions();
//		MaindropdownParadas.options.Add (new Dropdown.OptionData() {text="Seleccioné una Parada"});
//
//		if (idLinea != 0) {
//			StartCoroutine (ParadasRutina ());
//		}
//	}
//
//	public void SetDropdownIndex(int index) {
//		Maindropdown.value = index;
//	}

#endregion



#region PARADAS
	IEnumerator ParadasRutina() {
		string url = "http://www.bondicom.com.ar/responders/bondicomResponder.aspx?paradasJson="+idLinea;
		WWW www = new WWW(url);

		yield return www;
		if (www.error == null){
			Debug.Log("Parada" + www.data);
			ProcessParada(www.data);
		}else{
			Debug.Log("ERROR: " + www.error);
		}
	}

	private void ProcessParada(string jsonString){
		JsonData jsonParada = JsonMapper.ToObject(jsonString);
		Parada parada;

		for(int i = 0; i<jsonParada["row"].Count; i++){	
			parada = new Parada();

			parada.Code = Convert.ToInt16(jsonParada["row"][i]["Code"].ToString());
			parada.Descripcion = jsonParada["row"][i]["Descripcion"].ToString();
			parada.id = Convert.ToInt32(jsonParada["row"][i]["Id"].ToString());
			parada.Latitud = jsonParada["row"][i]["Latitud"].ToString();
			parada.Longitud = jsonParada["row"][i]["Longitud"].ToString();
			parada.Recorrido = jsonParada["row"][i]["Recorrido"].ToString();

			//MaindropdownParadas.options.Add (new Dropdown.OptionData() {text=parada.Descripcion});
			ParadasLista[i].GetComponentInChildren<Text>().text = "";
			ParadasLista[i].SetActive(true);
			ParadasLista[i].GetComponentInChildren<Text>().text = parada.Descripcion;
			Paradas.Add(parada.Code.ToString());

			Latitud = parada.Latitud;
			Longitud = parada.Longitud;
			double.TryParse (Latitud, out Lati);
			double.TryParse (Longitud, out Longi);
			Latitudes.Add (Lati);
			Longitudes.Add (Longi);
			// ACA AGREGAR UNA LITA DE LAT Y OTRA D LONG y sertear cuando elijo la Parada mas abajo.
		}
	}

	public void SaberParadas(int index){
		idParada = int.Parse(Paradas [index]);	
		Debug.Log ("Soy el: " + Paradas[index]);
		Fondo.SetActive (false);
		Fondo2.SetActive (false);
		Barra.SetActive (false);
		FondoNegro.SetActive (false);
		Cartel.SetActive (false);
		InternoLista.Clear ();
		CartelLista.Clear ();
		ArriboLista.Clear ();
		DestinoLista.Clear ();

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

		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 0;
		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = false;
		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = false;

		OnlineMaps.latitude = Latitudes[index];
		OnlineMaps.longitude = Longitudes[index];


		StartCoroutine (InfoParada ());


	}


//	private void myDropdownValueChangedHandlerParada(Dropdown targetParada) {
//		idParada = int.Parse(Paradas [targetParada.value]);
//
//		if (idParada != 0) {
//			StartCoroutine (InfoParada ());
//		}
//
//	}
//
//	public void SetDropdownIndexParada(int indexParada) {
//		MaindropdownParadas.value = indexParada;
//	}

#endregion



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
			//aca agregar una Lista para las lat y long de los colectivos.

//			Latitud = prediccion.lat;
//			Longitud = prediccion.lon;
//			double.TryParse (Latitud, out Lati);
//			double.TryParse (Longitud, out Longi);
		}

		Interno1.text = InternoLista [0];	
		Cartel1.text = CartelLista [0];
		Arribo1.text = ArriboLista [0];
		Destino1.text = DestinoLista [0];
		Interno2.text = InternoLista [1];	
		Cartel2.text = CartelLista [1];		
		Arribo2.text = ArriboLista [1];		
		Destino2.text = DestinoLista [1];	
		Cartel3.text = CartelLista [2];		
		Interno3.text = InternoLista [2];	
		Arribo3.text = ArriboLista [2];		
		Destino3.text = DestinoLista [2];	
		Cartel4.text = CartelLista [3];
		Interno4.text = InternoLista [3];
		Arribo4.text = ArriboLista [3];
		Destino4.text = DestinoLista [3];
		//OnlineMaps.latitude = Lati;
		//OnlineMaps.longitude = Longi;

		BlockeadorParadas.SetActive (false);
		Test01 = true;
		HayUno = true;
		Mapas.zoom = 15;
		Mapas.zoom = 16;

	}
}


