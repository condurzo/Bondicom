using UnityEngine;
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
	public List<float> LatitudesPokeParada = new List<float>();
	public List<float> LongitudesPokeParada = new List<float>();
	public List<float> LatitudesColectivos = new List<float>();
	public List<float> LongitudesColectivos = new List<float>();
	public float LatCole;
	public float LongCole;
	public float LatPokeParada;
	public float LongPokeParada;
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
	public GameObject PPoke1, PPoke12, PPoke39, PPoke68, PPoke102, PPoke110, PPoke126, PPoke501, PPoke503P, PPokeCOR, PPokeSPC;
	public GameObject BlockeadorParadas;
	public GameObject PokeScalar;
	public int TempArray;
	public string LineaPoke;
	public Texture2D Colectivo2D;
	public int ContadorListado;
	public static bool agregando1, agregando2, agregando3, agregando4, agregando5, agregando6, agregandoNew;


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
		PlayerPrefs.SetInt ("TempLineaId", 253);
		PrediccionJson.ActivadorJson = true;
		LineaPoke = "1";
		BlockeadorParadas.SetActive (true);
		OnlineMapsControlBase3D.instance.RemoveAllMarker3D ();
		Mapas.RemoveAllMarkers ();
		idLinea = 253;
		LatitudesColectivos.Clear ();
		LongitudesColectivos.Clear ();
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		LatitudesPokeParada.Clear ();
		LongitudesPokeParada.Clear ();
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
		PlayerPrefs.SetInt ("TempLineaId", 254);
		PrediccionJson.ActivadorJson = true;
		LineaPoke = "12";
		BlockeadorParadas.SetActive (true);
		OnlineMapsControlBase3D.instance.RemoveAllMarker3D ();
		Mapas.RemoveAllMarkers ();
		idLinea = 254;
		LatitudesColectivos.Clear ();
		LongitudesColectivos.Clear ();
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		LatitudesPokeParada.Clear ();
		LongitudesPokeParada.Clear ();
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
		PlayerPrefs.SetInt ("TempLineaId", 255);
		PrediccionJson.ActivadorJson = true;
		LineaPoke = "39";
		BlockeadorParadas.SetActive (true);
		OnlineMapsControlBase3D.instance.RemoveAllMarker3D ();
		Mapas.RemoveAllMarkers ();
		idLinea = 255;
		LatitudesColectivos.Clear ();
		LongitudesColectivos.Clear ();
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		LatitudesPokeParada.Clear ();
		LongitudesPokeParada.Clear ();
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
		PlayerPrefs.SetInt ("TempLineaId", 306);
		PrediccionJson.ActivadorJson = true;
		LineaPoke = "68";
		BlockeadorParadas.SetActive (true);
		OnlineMapsControlBase3D.instance.RemoveAllMarker3D ();
		Mapas.RemoveAllMarkers ();
		idLinea = 306;
		LatitudesColectivos.Clear ();
		LongitudesColectivos.Clear ();
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		LatitudesPokeParada.Clear ();
		LongitudesPokeParada.Clear ();
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
		PlayerPrefs.SetInt ("TempLineaId", 308);
		PrediccionJson.ActivadorJson = true;
		LineaPoke = "102";
		BlockeadorParadas.SetActive (true);
		OnlineMapsControlBase3D.instance.RemoveAllMarker3D ();
		Mapas.RemoveAllMarkers ();
		idLinea = 308;
		LatitudesColectivos.Clear ();
		LongitudesColectivos.Clear ();
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		LatitudesPokeParada.Clear ();
		LongitudesPokeParada.Clear ();
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
		PlayerPrefs.SetInt ("TempLineaId", 315);
		PrediccionJson.ActivadorJson = true;
		LineaPoke = "110";
		BlockeadorParadas.SetActive (true);
		OnlineMapsControlBase3D.instance.RemoveAllMarker3D ();
		Mapas.RemoveAllMarkers ();
		idLinea = 315;
		LatitudesColectivos.Clear ();
		LongitudesColectivos.Clear ();
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		LatitudesPokeParada.Clear ();
		LongitudesPokeParada.Clear ();
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
		PlayerPrefs.SetInt ("TempLineaId", 300);
		PrediccionJson.ActivadorJson = true;
		LineaPoke = "126";
		BlockeadorParadas.SetActive (true);
		OnlineMapsControlBase3D.instance.RemoveAllMarker3D ();
		Mapas.RemoveAllMarkers ();
		idLinea = 300;
		LatitudesColectivos.Clear ();
		LongitudesColectivos.Clear ();
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		LatitudesPokeParada.Clear ();
		LongitudesPokeParada.Clear ();
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
		PlayerPrefs.SetInt ("TempLineaId", 244);
		PrediccionJson.ActivadorJson = true;
		LineaPoke = "501";
		BlockeadorParadas.SetActive (true);
		OnlineMapsControlBase3D.instance.RemoveAllMarker3D ();
		Mapas.RemoveAllMarkers ();
		idLinea = 244;
		LatitudesColectivos.Clear ();
		LongitudesColectivos.Clear ();
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		LatitudesPokeParada.Clear ();
		LongitudesPokeParada.Clear ();
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
		PlayerPrefs.SetInt ("TempLineaId", 237);
		PrediccionJson.ActivadorJson = true;
		LineaPoke = "503P";
		BlockeadorParadas.SetActive (true);
		OnlineMapsControlBase3D.instance.RemoveAllMarker3D ();
		Mapas.RemoveAllMarkers ();
		idLinea = 237;
		LatitudesColectivos.Clear ();
		LongitudesColectivos.Clear ();
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		LatitudesPokeParada.Clear ();
		LongitudesPokeParada.Clear ();
		foreach (GameObject listaPa in ParadasLista) {
			listaPa.SetActive (false);	
				}
		Barra.SetActive (true);
		ListaParadaGO.GetComponent<CanvasGroup> ().alpha = 1;
		ListaParadaGO.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		ListaParadaGO.GetComponent<CanvasGroup> ().interactable = true;
		StartCoroutine (ParadasRutina ());
	}
	public void LineaCORBtn(){
		PlayerPrefs.SetInt ("TempLineaId", 280);
		PrediccionJson.ActivadorJson = true;
		LineaPoke = "COR";
		BlockeadorParadas.SetActive (true);
		OnlineMapsControlBase3D.instance.RemoveAllMarker3D ();
		Mapas.RemoveAllMarkers ();
		idLinea = 280;
		LatitudesColectivos.Clear ();
		LongitudesColectivos.Clear ();
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		LatitudesPokeParada.Clear ();
		LongitudesPokeParada.Clear ();
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
		PlayerPrefs.SetInt ("TempLineaId", 318);
		PrediccionJson.ActivadorJson = true;
		LineaPoke = "SPC";
		BlockeadorParadas.SetActive (true);
		OnlineMapsControlBase3D.instance.RemoveAllMarker3D ();
		Mapas.RemoveAllMarkers ();
		idLinea = 318;
		LatitudesColectivos.Clear ();
		LongitudesColectivos.Clear ();
		Paradas.Clear ();
		Latitudes.Clear ();
		Longitudes.Clear ();
		LatitudesPokeParada.Clear ();
		LongitudesPokeParada.Clear ();
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

			LatPokeParada = float.Parse(parada.Latitud);
			LongPokeParada = float.Parse(parada.Longitud);
			LatitudesPokeParada.Add (LatPokeParada);
			LongitudesPokeParada.Add (LongPokeParada);
		}
	}

	public void SaberParadas(int index){
		idParada = int.Parse(Paradas [index]);	
		PlayerPrefs.SetInt ("TempParadaId", idParada);
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
		double TempLatIndex = Latitudes[index];
		double TempLongIndex = Longitudes[index];
		PlayerPrefs.SetFloat ("LatitudTemp", (float)TempLatIndex);
		PlayerPrefs.SetFloat ("LongitudTemp",(float)TempLongIndex);

		switch (LineaPoke) {
		case "1":
			OnlineMapsControlBase3D.instance.AddMarker3D (new Vector2 (LongitudesPokeParada [index], LatitudesPokeParada [index]), PPoke1);
			Mapas.RemoveAllMarkers ();
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (ParadasLista [index].GetComponentInChildren<Text> ().text);
			break;
		case "12":
			OnlineMapsControlBase3D.instance.AddMarker3D (new Vector2 (LongitudesPokeParada [index], LatitudesPokeParada [index]), PPoke12);
			Mapas.RemoveAllMarkers ();
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (ParadasLista [index].GetComponentInChildren<Text> ().text);
			break;
		case "39":
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongitudesPokeParada[index], LatitudesPokeParada[index]),PPoke39);
			Mapas.RemoveAllMarkers ();
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (ParadasLista [index].GetComponentInChildren<Text> ().text);
			break;
		case "68":
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongitudesPokeParada[index], LatitudesPokeParada[index]),PPoke68);
			Mapas.RemoveAllMarkers ();
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (ParadasLista [index].GetComponentInChildren<Text> ().text);
			break;
		case "102":
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongitudesPokeParada[index], LatitudesPokeParada[index]),PPoke102);
			Mapas.RemoveAllMarkers ();
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (ParadasLista [index].GetComponentInChildren<Text> ().text);
			break;
		case "110":
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongitudesPokeParada[index], LatitudesPokeParada[index]),PPoke110);
			Mapas.RemoveAllMarkers ();
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (ParadasLista [index].GetComponentInChildren<Text> ().text);
			break;
		case "126":
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongitudesPokeParada[index], LatitudesPokeParada[index]),PPoke126);
			Mapas.RemoveAllMarkers ();
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (ParadasLista [index].GetComponentInChildren<Text> ().text);
			break;
		case "501":
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongitudesPokeParada[index], LatitudesPokeParada[index]),PPoke501);
			Mapas.RemoveAllMarkers ();
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (ParadasLista [index].GetComponentInChildren<Text> ().text);
			break;
		case "503P":
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongitudesPokeParada[index], LatitudesPokeParada[index]),PPoke503P);
			Mapas.RemoveAllMarkers ();
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (ParadasLista [index].GetComponentInChildren<Text> ().text);
			break;
		case "COR":
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongitudesPokeParada[index], LatitudesPokeParada[index]),PPokeCOR);
			Mapas.RemoveAllMarkers ();
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (ParadasLista [index].GetComponentInChildren<Text> ().text);
			break;
		case "SPC":
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (LongitudesPokeParada[index], LatitudesPokeParada[index]),PPokeSPC);
			Mapas.RemoveAllMarkers ();
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (ParadasLista [index].GetComponentInChildren<Text> ().text);
			break;
			
		}

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
			TempArray = i;

			LatCole = float.Parse(prediccion.lat);
			LongCole = float.Parse(prediccion.lon);
			LatitudesColectivos.Add (LatCole);
			LongitudesColectivos.Add (LongCole);
			//aca agregar una Lista para las lat y long de los colectivos.

		}
		if (TempArray >= 0) {
			Interno1.text = InternoLista [0];	
			Cartel1.text = CartelLista [0];
			Arribo1.text = ArriboLista [0];
			Destino1.text = DestinoLista [0];
			string TempDatos = InternoLista [0] + " - :" + ArriboLista [0] +"\r\n"+ " a " + DestinoLista [0];
			Mapas.AddMarker (new Vector2 (LongitudesColectivos [0], LatitudesColectivos [0]), Colectivo2D, TempDatos);
		}
		if (TempArray >= 1) {
			Interno2.text = InternoLista [1];	
			Cartel2.text = CartelLista [1];		
			Arribo2.text = ArriboLista [1];		
			Destino2.text = DestinoLista [1];
			string TempDatos = InternoLista [1] + " - :" + ArriboLista [1] +"\r\n"+ " a " + DestinoLista [1];
			Mapas.AddMarker (new Vector2 (LongitudesColectivos [1], LatitudesColectivos [1]), Colectivo2D, TempDatos);
		}
		if (TempArray >= 2) {
			Cartel3.text = CartelLista [2];		
			Interno3.text = InternoLista [2];	
			Arribo3.text = ArriboLista [2];		
			Destino3.text = DestinoLista [2];
			string TempDatos = InternoLista [2] + " - :" + ArriboLista [2] +"\r\n"+ " a " + DestinoLista [2];
			Mapas.AddMarker (new Vector2 (LongitudesColectivos [2], LatitudesColectivos [2]), Colectivo2D, TempDatos);
		}
		if (TempArray >= 3) {
			Cartel4.text = CartelLista [3];
			Interno4.text = InternoLista [3];
			Arribo4.text = ArriboLista [3];
			Destino4.text = DestinoLista [3];
			string TempDatos = InternoLista [3] + " - :" + ArriboLista [3] +"\r\n"+ " a " + DestinoLista [3];
			Mapas.AddMarker (new Vector2 (LongitudesColectivos [3], LatitudesColectivos [3]), Colectivo2D, TempDatos);
		}




		BlockeadorParadas.SetActive (false);
		Mapas.zoom = 16;
		Mapas.zoom = 15;

	}



	public void Agregar(string Nombre){
		
		if (ContadorListado == 0) {
			PlayerPrefs.SetString ("PPL0", Nombre);
			agregando1 = true;
			PlayerPrefs.SetInt ("Activo1", 1);
		}
		if (ContadorListado == 1) {
			PlayerPrefs.SetString ("PPL1", Nombre);
			agregando2 = true;
			PlayerPrefs.SetInt ("Activo2", 1);
		}
		if (ContadorListado == 2) {
			PlayerPrefs.SetString ("PPL2", Nombre);
			agregando3 = true;
			PlayerPrefs.SetInt ("Activo3", 1);
		}
		if (ContadorListado == 3) {
			PlayerPrefs.SetString ("PPL3", Nombre);
			agregando4 = true;
			PlayerPrefs.SetInt ("Activo4", 1);
		}
		if (ContadorListado == 4) {
			PlayerPrefs.SetString ("PPL4", Nombre);
			agregando5 = true;
			PlayerPrefs.SetInt ("Activo5", 1);
		}
		if (ContadorListado == 5) {
			PlayerPrefs.SetString ("PPL5", Nombre);
			agregando6 = true;
			PlayerPrefs.SetInt ("Activo6", 1);
		}
		if (ContadorListado >= 6) {
			PlayerPrefs.SetString ("NewPP", Nombre);
			agregandoNew = true;
		}
	}
}


