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
	public List<string> CartelLista = new List<string>();
	public List<string> ArriboLista = new List<string>();
	public List<string> DestinoLista = new List<string>();

	public Text Interno1,Interno2,Interno3,Interno4;
	public Text Cartel1,Cartel2,Cartel3,Cartel4;
	public Text Arribo1,Arribo2,Arribo3,Arribo4;
	public Text Destino1,Destino2,Destino3,Destino4;

	public List<List<string>> PadreInternoLista = new List<List<string>>();

	public int TempArrayPP;
	public int contadorArray;

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

		if (Activacion.label0) {
			Interno1.text = InternoLista0 [0];
			Interno2.text = InternoLista0 [1];
			Interno3.text = InternoLista0 [2];
			Interno4.text = InternoLista0 [3];
			Debug.Log ("Toco 0");
			Activacion.label0 = false;
		}
		if (Activacion.label1) {
			Interno1.text = InternoLista1 [0];
			Interno2.text = InternoLista1 [1];
			Interno3.text = InternoLista1 [2];
			Interno4.text = InternoLista1 [3];
			Debug.Log ("Toco 1");
			Activacion.label1 = false;
		}
		if (Activacion.label2) {
			Interno1.text = InternoLista2 [0];
			Interno2.text = InternoLista2 [1];
			Interno3.text = InternoLista2 [2];
			Interno4.text = InternoLista2 [3];
			Debug.Log ("Toco 2");
			Activacion.label2 = false;
		}
		if (Activacion.label3) {
			Interno1.text = InternoLista3 [0];
			Interno2.text = InternoLista3 [1];
			Interno3.text = InternoLista3 [2];
			Interno4.text = InternoLista3 [3];
			Debug.Log ("Toco 3");
			Activacion.label3 = false;
		}
		if (Activacion.label4) {
			Interno1.text = InternoLista4 [0];
			Interno2.text = InternoLista4 [1];
			Interno3.text = InternoLista4 [2];
			Interno4.text = InternoLista4 [3];
			Activacion.label4 = false;
		}
//		if (Activacion.label5) {
//			Interno1.text = InternoLista5 [0];
//			Interno2.text = InternoLista5 [1];
//			Interno3.text = InternoLista5 [2];
//			Interno4.text = InternoLista5 [3];
//			Activacion.label5 = false;
//		}
		if (Activacion.label6) {
			Interno1.text = PadreInternoLista [6] [0];
			Interno2.text = PadreInternoLista [6] [1];
			Interno3.text = PadreInternoLista [6] [2];
			Interno4.text = PadreInternoLista [6] [3];
			Activacion.label6 = false;
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
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke1);
			break;
		case 254://LINEA 12
			OnlineMapsControlBase3D.instance.AddMarker3D (new Vector2 (Longitudes [ArrayNumTemp], Latitudes [ArrayNumTemp]), PPoke12);
			OnlineMapsControlBase3D.instance.markers3D [ArrayNumber].label = ArrayNumber.ToString ();
			break;
		case 255://LINEA 39
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke39);
			break;
		case 306://LINEA 68
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke68);
			break;
		case 308://LINEA 102
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke102);
			break;
		case 315://LINEA 110
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke110);
			break;
		case 300://LINEA 126
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke126);
			break;
		case 244://LINEA 501
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke501);
			break;
		case 237://LINEA 503P
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPoke503P);
			break;
		case 280://LINEA COR
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPokeCOR);
			break;
		case 318://LINEA SPC
			OnlineMapsControlBase3D.instance.AddMarker3D(new Vector2 (Longitudes[ArrayNumTemp], Latitudes[ArrayNumTemp]),PPokeSPC);
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
				CartelLista.Add (prediccionPP.cartel.ToString ());
				ArriboLista.Add (prediccionPP.t.ToString ());
				DestinoLista.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}

			if (i == 1) {
				InternoLista1.Add (prediccionPP.i.ToString ());
				CartelLista.Add (prediccionPP.cartel.ToString ());
				ArriboLista.Add (prediccionPP.t.ToString ());
				DestinoLista.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 2) {
				InternoLista2.Add (prediccionPP.i.ToString ());
				CartelLista.Add (prediccionPP.cartel.ToString ());
				ArriboLista.Add (prediccionPP.t.ToString ());
				DestinoLista.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 3) {
				InternoLista3.Add (prediccionPP.i.ToString ());
				CartelLista.Add (prediccionPP.cartel.ToString ());
				ArriboLista.Add (prediccionPP.t.ToString ());
				DestinoLista.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 4) {
				InternoLista4.Add (prediccionPP.i.ToString ());
				CartelLista.Add (prediccionPP.cartel.ToString ());
				ArriboLista.Add (prediccionPP.t.ToString ());
				DestinoLista.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 5) {
				InternoLista5.Add (prediccionPP.i.ToString ());
				CartelLista.Add (prediccionPP.cartel.ToString ());
				ArriboLista.Add (prediccionPP.t.ToString ());
				DestinoLista.Add (prediccionPP.hacia.ToString ());
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
