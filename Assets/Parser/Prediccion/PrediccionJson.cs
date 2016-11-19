using UnityEngine;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PrediccionJson : MonoBehaviour {
	
	public OnlineMaps Mapas;
	public static bool parsear;
	public List<float> Latitudes = new List<float>();
	public List<float> Longitudes = new List<float>();
	public float Latitud;
	public float Longitud;
	public int TempArray;
	public List<int> idLinea = new List<int>();
	public int LineaColectivo;
	public int ArrayNumber;
	public GameObject PPoke1, PPoke12, PPoke39, PPoke68, PPoke102, PPoke110, PPoke126, PPoke501, PPoke503P, PPokeCOR, PPokeSPC;
	public List<float> Checker = new List<float>();
	public List<float> Checker2 = new List<float>();
	public int idParadaTemp, idLineaTemp;
	public List<int> idParadaList = new List<int>();
	public List<int> idLineaList = new List<int>(); 
	//public List<string> InternoListaPadre = new List<string>();
	public List<string> InternoLista0 = new List<string>();
	public List<string> InternoLista1 = new List<string>();
	public List<string> InternoLista2 = new List<string>();
	public List<string> InternoLista3 = new List<string>();
	public List<string> InternoLista4 = new List<string>();
	public List<string> InternoLista5 = new List<string>();
	public List<string> InternoLista6 = new List<string>();
	public List<string> InternoLista7 = new List<string>();
	public List<string> InternoLista8 = new List<string>();
	public List<string> InternoLista9 = new List<string>();
	public List<string> InternoLista10 = new List<string>();
	public List<string> InternoLista11 = new List<string>();
	public List<string> InternoLista12 = new List<string>();
	public List<string> InternoLista13 = new List<string>();
	public List<string> InternoLista14 = new List<string>();
	public List<string> InternoLista15 = new List<string>();
	public List<string> InternoLista16 = new List<string>();
	public List<string> InternoLista17 = new List<string>();
	public List<string> InternoLista18 = new List<string>();
	public List<string> InternoLista19 = new List<string>();
	public List<string> CartelLista0 = new List<string>();
	public List<string> CartelLista1 = new List<string>();
	public List<string> CartelLista2 = new List<string>();
	public List<string> CartelLista3 = new List<string>();
	public List<string> CartelLista4 = new List<string>();
	public List<string> CartelLista5 = new List<string>();
	public List<string> CartelLista6 = new List<string>();
	public List<string> CartelLista7 = new List<string>();
	public List<string> CartelLista8 = new List<string>();
	public List<string> CartelLista9 = new List<string>();
	public List<string> CartelLista10 = new List<string>();
	public List<string> CartelLista11= new List<string>();
	public List<string> CartelLista12= new List<string>();
	public List<string> CartelLista13= new List<string>();
	public List<string> CartelLista14= new List<string>();
	public List<string> CartelLista15= new List<string>();
	public List<string> CartelLista16= new List<string>();
	public List<string> CartelLista17= new List<string>();
	public List<string> CartelLista18= new List<string>();
	public List<string> CartelLista19 = new List<string>();
	public List<string> ArriboLista0 = new List<string>();
	public List<string> ArriboLista1 = new List<string>();
	public List<string> ArriboLista2 = new List<string>();
	public List<string> ArriboLista3 = new List<string>();
	public List<string> ArriboLista4 = new List<string>();
	public List<string> ArriboLista5 = new List<string>();
	public List<string> ArriboLista6 = new List<string>();
	public List<string> ArriboLista7 = new List<string>();
	public List<string> ArriboLista8 = new List<string>();
	public List<string> ArriboLista9 = new List<string>();
	public List<string> ArriboLista10 = new List<string>();
	public List<string> ArriboLista11 = new List<string>();
	public List<string> ArriboLista12 = new List<string>();
	public List<string> ArriboLista13 = new List<string>();
	public List<string> ArriboLista14 = new List<string>();
	public List<string> ArriboLista15 = new List<string>();
	public List<string> ArriboLista16 = new List<string>();
	public List<string> ArriboLista17 = new List<string>();
	public List<string> ArriboLista18 = new List<string>();
	public List<string> ArriboLista19 = new List<string>();
	public List<string> DestinoLista0 = new List<string>();
	public List<string> DestinoLista1 = new List<string>();
	public List<string> DestinoLista2 = new List<string>();
	public List<string> DestinoLista3 = new List<string>();
	public List<string> DestinoLista4 = new List<string>();
	public List<string> DestinoLista5 = new List<string>();
	public List<string> DestinoLista6 = new List<string>();
	public List<string> DestinoLista7 = new List<string>();
	public List<string> DestinoLista8 = new List<string>();
	public List<string> DestinoLista9 = new List<string>();
	public List<string> DestinoLista10 = new List<string>();
	public List<string> DestinoLista11 = new List<string>();
	public List<string> DestinoLista12 = new List<string>();
	public List<string> DestinoLista13 = new List<string>();
	public List<string> DestinoLista14 = new List<string>();
	public List<string> DestinoLista15 = new List<string>();
	public List<string> DestinoLista16 = new List<string>();
	public List<string> DestinoLista17 = new List<string>();
	public List<string> DestinoLista18 = new List<string>();
	public List<string> DestinoLista19 = new List<string>();


	public Text Interno1,Interno2,Interno3,Interno4;
	public Text Cartel1,Cartel2,Cartel3,Cartel4;
	public Text Arribo1,Arribo2,Arribo3,Arribo4;
	public Text Destino1,Destino2,Destino3,Destino4;

	public List<List<string>> PadreInternoLista = new List<List<string>>();

	public int TempArrayPP;
	public int contadorArray;

	public List<Activacion> markerList;

	public int currentId=0;
	OnlineMapsMarker3D mark;
	Activacion auxM;

	public static bool ActivadorJson;

	#if UNITY_EDITOR
	public IEnumerator Start()
	{
		Debug.Log ("Hola");
		Mapas.zoom = 16;
		Mapas.zoom = 15;
		//Load JSON data from a URL

		string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson=-34.608&longUnicaJson=-58.392&metros=200";//Linea12
		//string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson=-34.584&longUnicaJson=-58.453&metros=1200";//Linea 39
		//string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson=-34.59549&longUnicaJson=-58.39793&metros=200";//12 Bis
		//string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson=-34.82636&longUnicaJson=-58.39172&metros=500";//Linea 501
		//string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latitudJson=-34.826&longitudJson=-58.391&metros=100";//501 viejo json
		//string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson="+GeoNativo.LatMia+"&longUnicaJson="+GeoNativo.LongMia+"&metros=200";
		WWW www = new WWW(url);

		//Load the data and yield (wait) till it's ready before we continue executing the rest of this method.
		yield return www;
		if (www.error == null)
		{
			//Sucessfully loaded the JSON string
			Debug.Log("Paradas Cercanas" + www.data);

			//Process books found in JSON file
			ProcessPrediccion(www.data);
		}
		else
		{
			Debug.Log("ERROR: " + www.error);
		}

	}
	#endif

	void Update(){
		if (parsear) {
			Debug.Log ("PASE");
			StartCoroutine(Parseador ());
			parsear = false;
		}

		if (Activacion.vaciarTodos) {
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
			Activacion.vaciarTodos = false;
		}

		if (Activacion.idPP0) {
			if (InternoLista0.Count == 0) {
				InternoLista0.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista0 [0];
				Cartel1.text = CartelLista0[0];
				Arribo1.text = ArriboLista0[0];
				Destino1.text =DestinoLista0[0];
			}
			if (InternoLista0.Count < 2) {
				InternoLista0.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista0 [1];
				Cartel2.text = CartelLista0[1];
				Arribo2.text = ArriboLista0[1];
				Destino2.text =DestinoLista0[1];
			}
			if (InternoLista0.Count < 3) {
				InternoLista0.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista0 [2];
				Cartel3.text = CartelLista0[2];
				Arribo3.text = ArriboLista0[2];
				Destino3.text =DestinoLista0[2];
			}
			if (InternoLista0.Count < 4) {
				InternoLista0.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista0 [3];
				Cartel4.text = CartelLista0[3];
				Arribo4.text = ArriboLista0[3];
				Destino4.text =DestinoLista0[3];
			}
			Activacion.idPP0 = false;
		}

		if (Activacion.idPP1) {
			if (InternoLista1.Count == 0) {
				InternoLista1.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista2 [0];
				Cartel1.text = CartelLista1[0];
				Arribo1.text = ArriboLista1[0];
				Destino1.text =DestinoLista1[0];
			}
			if (InternoLista1.Count < 2) {
				InternoLista1.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista1 [1];
				Cartel2.text = CartelLista1[1];
				Arribo2.text = ArriboLista1[1];
				Destino2.text =DestinoLista1[1];
			}
			if (InternoLista1.Count < 3) {
				InternoLista1.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista1 [2];
				Cartel3.text = CartelLista1[2];
				Arribo3.text = ArriboLista1[2];
				Destino3.text =DestinoLista1[2];
			}
			if (InternoLista1.Count < 4) {
				InternoLista1.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista1 [3];
				Cartel4.text = CartelLista1[3];
				Arribo4.text = ArriboLista1[3];
				Destino4.text =DestinoLista1[3];
			}
			Activacion.idPP1 = false;
		}

		if (Activacion.idPP2) {
			if (InternoLista2.Count == 0) {
				InternoLista2.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista2 [0];
				Cartel1.text = CartelLista2[0];
				Arribo1.text = ArriboLista2[0];
				Destino1.text =DestinoLista2[0];
			}
			if (InternoLista2.Count < 2) {
				InternoLista2.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista2 [1];
				Cartel2.text = CartelLista2[1];
				Arribo2.text = ArriboLista2[1];
				Destino2.text =DestinoLista2[1];
			}
			if (InternoLista2.Count < 3) {
				InternoLista2.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista2 [2];
				Cartel3.text = CartelLista2[2];
				Arribo3.text = ArriboLista2[2];
				Destino3.text =DestinoLista2[2];
			}
			if (InternoLista2.Count < 4) {
				InternoLista2.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista2 [3];
				Cartel4.text = CartelLista2[3];
				Arribo4.text = ArriboLista2[3];
				Destino4.text =DestinoLista2[3];
			}
			Activacion.idPP2 = false;
		}
	}


	public IEnumerator Parseador()
	{
		Debug.Log ("Hola");
		Mapas.zoom = 16;
		Mapas.zoom = 15;
		//Load JSON data from a URL
		string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson=-34.608&longUnicaJson=-58.392&metros=200";
		//string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson="+GeoNativo.LatMia+"&longUnicaJson="+GeoNativo.LongMia+"&metros=200";
		WWW www = new WWW(url);

		//Load the data and yield (wait) till it's ready before we continue executing the rest of this method.
		yield return www;
		if (www.error == null)
		{
			//Sucessfully loaded the JSON string
			Debug.Log("Paradas Cercanas" + www.data);

			//Process books found in JSON file
			ProcessPrediccion(www.data);
		}
		else
		{
			Debug.Log("ERROR: " + www.error);
		}

	}



	//Converts a JSON string into Book objects and shows a book out of it on the screen
	private void ProcessPrediccion(string jsonString){
		JsonData jsonPrediccion = JsonMapper.ToObject(jsonString);
		PrediccionCercano prediccion;

		for(int i = 0; i<jsonPrediccion["row"].Count; i++){	
			prediccion = new PrediccionCercano();

			//prediccion.cartel = jsonPrediccion["row"][i]["cartel"].ToString();
			prediccion.code = Convert.ToInt16(jsonPrediccion["row"][i]["code"].ToString());
			prediccion.descripcion = jsonPrediccion["row"][i]["descripcion"].ToString();
			prediccion.fkEmpresa = Convert.ToInt16(jsonPrediccion["row"][i]["fkEmpresa"].ToString());
			prediccion.fkLinea = Convert.ToInt16(jsonPrediccion["row"][i]["fkLinea"].ToString());
			prediccion.lat = jsonPrediccion["row"][i]["lat"].ToString();
			prediccion.lon = jsonPrediccion["row"][i]["lon"].ToString();


//			Debug.Log ("Cartel: " + prediccion.cartel);
			//Debug.Log ("Code: " + prediccion.code);
//			Debug.Log ("Cartel: " + prediccion.descripcion);
//			Debug.Log ("Cartel: " + prediccion.fkEmpresa);
			//Debug.Log ("Linea: " + prediccion.fkLinea);
//			Debug.Log ("Cartel: " + prediccion.lat);
//			Debug.Log ("Cartel: " + prediccion.lon);
//			Latitud = float.Parse(prediccion.lat);
//			Checker2.Add(Latitud);
//			idParadaTemp = prediccion.code;
//			idLineaTemp = prediccion.fkLinea;
			idParadaList.Add(prediccion.code);
			idLineaList.Add (prediccion.fkLinea);
			Latitud = float.Parse(prediccion.lat);
			Longitud = float.Parse(prediccion.lon);
			Latitudes.Add (Latitud);
			Longitudes.Add (Longitud);
			TempArray = i;
			idLinea.Add (prediccion.fkLinea);
			StartCoroutine (InfoParada());
		}

		//StartCoroutine (InfoParada());

		if (TempArray >= 0) {
			LineaColectivo = idLinea [0];
			ArrayNumber = 0;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 1) {
			LineaColectivo = idLinea [1];
			ArrayNumber = 1;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 2) {
			LineaColectivo = idLinea [2];
			ArrayNumber = 2;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 3) {
			LineaColectivo = idLinea [3];
			ArrayNumber = 3;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 4) {
			LineaColectivo = idLinea [4];
			ArrayNumber = 4;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 5) {
			LineaColectivo = idLinea [5];
			ArrayNumber = 5;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 6) {
			LineaColectivo = idLinea [6];
			ArrayNumber = 6;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 7) {
			LineaColectivo = idLinea [7];
			ArrayNumber = 7;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 8) {
			LineaColectivo = idLinea [8];
			ArrayNumber = 8;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 9) {
			LineaColectivo = idLinea [9];
			ArrayNumber = 9;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 10) {
			LineaColectivo = idLinea [10];
			ArrayNumber = 10;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 11) {
			LineaColectivo = idLinea [11];
			ArrayNumber = 11;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 12) {
			LineaColectivo = idLinea [12];
			ArrayNumber = 12;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 13) {
			LineaColectivo = idLinea [13];
			ArrayNumber = 13;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 14) {
			LineaColectivo = idLinea [14];
			ArrayNumber = 14;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 15) {
			LineaColectivo = idLinea [15];
			ArrayNumber = 15;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 16) {
			LineaColectivo = idLinea [16];
			ArrayNumber = 16;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 17) {
			LineaColectivo = idLinea [17];
			ArrayNumber = 17;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 18) {
			LineaColectivo = idLinea [18];
			ArrayNumber = 18;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}
		if (TempArray >= 19) {
			LineaColectivo = idLinea [19];
			ArrayNumber = 19;
			PokeparadasSwicht (LineaColectivo,ArrayNumber);
		}

	}

	void PokeparadasSwicht(int LineaTemp,int ArrayNumTemp){
		switch (LineaTemp) {
		case 253://LINEA 1
			mark= OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke1);
			auxM = mark.instance.GetComponentInChildren<Activacion> ();
			auxM.id = currentId;
			currentId++;
			markerList.Add (auxM);
			break;
		case 254://LINEA 12
			mark= OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes [ArrayNumTemp], Latitudes [ArrayNumTemp]), PPoke12);
			//OnlineMapsControlBase3D.instance.AddMarker3D (new Vector2 (Longitudes [ArrayNumTemp], Latitudes [ArrayNumTemp]), PPoke12);
			//OnlineMapsControlBase3D.instance.markers3D [ArrayNumber].label = ArrayNumber.ToString ();
			auxM = mark.instance.GetComponentInChildren<Activacion> ();
			auxM.id = currentId;
			currentId++;
			markerList.Add (auxM);
			break;
		case 255://LINEA 39
			mark= OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke39);
			auxM = mark.instance.GetComponentInChildren<Activacion> ();
			auxM.id = currentId;
			currentId++;
			markerList.Add (auxM);
			break;
		case 306://LINEA 68
			mark= OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke68);
			auxM = mark.instance.GetComponentInChildren<Activacion> ();
			auxM.id = currentId;
			currentId++;
			markerList.Add (auxM);
			break;
		case 308://LINEA 102
			mark= OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke102);
			auxM = mark.instance.GetComponentInChildren<Activacion> ();
			auxM.id = currentId;
			currentId++;
			markerList.Add (auxM);
			break;
		case 315://LINEA 110
			mark= OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke110);
			auxM = mark.instance.GetComponentInChildren<Activacion> ();
			auxM.id = currentId;
			currentId++;
			markerList.Add (auxM);
			break;
		case 300://LINEA 126
			mark= OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke126);
			auxM = mark.instance.GetComponentInChildren<Activacion> ();
			auxM.id = currentId;
			currentId++;
			markerList.Add (auxM);
			break;
		case 244://LINEA 501
			mark= OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke501);
			auxM = mark.instance.GetComponentInChildren<Activacion> ();
			auxM.id = currentId;
			currentId++;
			markerList.Add (auxM);
			break;
		case 237://LINEA 503P
			mark= OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke503P);
			auxM = mark.instance.GetComponentInChildren<Activacion> ();
			auxM.id = currentId;
			currentId++;
			markerList.Add (auxM);
			break;
		case 280://LINEA COR
			mark= OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPokeCOR);
			auxM = mark.instance.GetComponentInChildren<Activacion> ();
			auxM.id = currentId;
			currentId++;
			markerList.Add (auxM);
			break;
		case 318://LINEA SPC
			mark= OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPokeSPC);
			auxM = mark.instance.GetComponentInChildren<Activacion> ();
			auxM.id = currentId;
			currentId++;
			markerList.Add (auxM);
			break;

		}
	}

	IEnumerator InfoParada(){
		//string url = "http://www.bondicom.com.ar/responders/bondicomResponder.aspx?prediccionJson="+idParadaList[TempArray]+"&lineasJson="+idLineaList[TempArray];
		string url = "http://www.bondicom.com.ar/responders/bondicomResponder.aspx?prediccionJson="+idParadaList[TempArray]+"&lineasJson="+idLineaList[TempArray];
		WWW www = new WWW(url);

		yield return www;
		if (www.error == null){
			Debug.Log("Parada" + www.data);

			ProcessPrediccionPP(www.data);
		}else{
			Debug.Log("ERROR: " + www.error);
		}

	}
	private void ProcessPrediccionPP(string jsonString){
		JsonData jsonPrediccionPP = JsonMapper.ToObject (jsonString);
		PrediccionPP prediccionPP;

		for (int i = 0; i < jsonPrediccionPP ["Table"].Count; i++) {	
			prediccionPP = new PrediccionPP ();
			prediccionPP.cartel = jsonPrediccionPP["Table"][i]["cartel"].ToString();
			prediccionPP.dif = Convert.ToInt16(jsonPrediccionPP["Table"][i]["dif"].ToString());
			prediccionPP.fkd = Convert.ToInt16(jsonPrediccionPP["Table"][i]["fkd"].ToString());
			prediccionPP.fkm = Convert.ToInt16(jsonPrediccionPP["Table"][i]["fkm"].ToString());
			prediccionPP.fkruta = Convert.ToInt16(jsonPrediccionPP["Table"][i]["fkruta"].ToString());
			prediccionPP.hacia = jsonPrediccionPP["Table"][i]["hacia"].ToString();
			prediccionPP.i = Convert.ToInt16(jsonPrediccionPP["Table"][i]["i"].ToString());
			prediccionPP.lat = jsonPrediccionPP["Table"][i]["lat"].ToString();
			prediccionPP.lon = jsonPrediccionPP["Table"][i]["lon"].ToString();
			prediccionPP.p_lat = jsonPrediccionPP["Table"][i]["p_lat"].ToString();
			prediccionPP.p_lon = jsonPrediccionPP["Table"][i]["p_lon"].ToString();
			prediccionPP.rampa = Convert.ToInt16(jsonPrediccionPP["Table"][i]["rampa"].ToString());
			prediccionPP.seg = Convert.ToInt16(jsonPrediccionPP["Table"][i]["seg"].ToString());
			prediccionPP.t = jsonPrediccionPP["Table"][i]["t"].ToString();

			if (i == 0) {
				InternoLista0.Add (prediccionPP.i.ToString ());
				CartelLista0.Add (prediccionPP.cartel.ToString ());
				ArriboLista0.Add (prediccionPP.t.ToString ());
				DestinoLista0.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}

			if (i == 1) {
				InternoLista1.Add (prediccionPP.i.ToString ());
				CartelLista1.Add (prediccionPP.cartel.ToString ());
				ArriboLista1.Add (prediccionPP.t.ToString ());
				DestinoLista1.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 2) {
				InternoLista2.Add (prediccionPP.i.ToString ());
				CartelLista2.Add (prediccionPP.cartel.ToString ());
				ArriboLista2.Add (prediccionPP.t.ToString ());
				DestinoLista2.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 3) {
				InternoLista3.Add (prediccionPP.i.ToString ());
				CartelLista3.Add (prediccionPP.cartel.ToString ());
				ArriboLista3.Add (prediccionPP.t.ToString ());
				DestinoLista3.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 4) {
				InternoLista4.Add (prediccionPP.i.ToString ());
				CartelLista4.Add (prediccionPP.cartel.ToString ());
				ArriboLista4.Add (prediccionPP.t.ToString ());
				DestinoLista4.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 5) {
				InternoLista5.Add (prediccionPP.i.ToString ());
				CartelLista5.Add (prediccionPP.cartel.ToString ());
				ArriboLista5.Add (prediccionPP.t.ToString ());
				DestinoLista5.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}

			//PadreInternoLista.Add (InternoLista);
		}
//		Debug.Log("Lista: " + PadreInternoLista[0][2]);//Primero Lista, Segundo Posicion
//		Debug.Log("Lista: " + PadreInternoLista[1][2]);
//		Debug.Log ("Lista: " + PadreInternoLista [2] [2]);
//		Debug.Log ("Lista: " + PadreInternoLista [3] [2]);
	}

}
