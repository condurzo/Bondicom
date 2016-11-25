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
	public List<string> Descripciones = new List<string>();
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

	public int ContadorListado;

	#if UNITY_EDITOR
	public IEnumerator Start()
	{
		Debug.Log ("Hola");
		Mapas.zoom = 16;
		Mapas.zoom = 15;
		//Load JSON data from a URL

		//string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson=-34.608&longUnicaJson=-58.392&metros=200";//Linea12
		//string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson=-34.584&longUnicaJson=-58.453&metros=1200";//Linea 39
		//string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson=-34.59549&longUnicaJson=-58.39793&metros=200";//12 Bis
		//string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson=-34.82636&longUnicaJson=-58.39172&metros=500";//Linea 501
		//string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latitudJson=-34.826&longitudJson=-58.391&metros=100";//501 viejo json
		string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson="+GeoNativo.LatMia+"&longUnicaJson="+GeoNativo.LongMia+"&metros=200";
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

		if (ActivadorJson) {
			idParadaList.Clear();
			idLineaList.Clear(); 
			Latitudes.Clear();
			Longitudes.Clear();
			Descripciones.Clear();

			InternoLista0.Clear();
			InternoLista1.Clear();
			InternoLista2.Clear();
			InternoLista3.Clear();
			InternoLista4.Clear();
			InternoLista5.Clear();
			InternoLista6.Clear();
			InternoLista7.Clear();
			InternoLista8.Clear();
			InternoLista9.Clear();
			InternoLista10.Clear();
			InternoLista11.Clear();
			InternoLista12.Clear();
			InternoLista13.Clear();
			InternoLista14.Clear();
			InternoLista15.Clear();
			InternoLista16.Clear();
			InternoLista17.Clear();
			InternoLista18.Clear();
			InternoLista19.Clear();
			CartelLista0.Clear();
			CartelLista1.Clear();
			CartelLista2.Clear();
			CartelLista3.Clear();
			CartelLista4.Clear();
			CartelLista5.Clear();
			CartelLista6.Clear();
			CartelLista7.Clear();
			CartelLista8.Clear();
			CartelLista9.Clear();
			CartelLista10.Clear();
			CartelLista11.Clear();
			CartelLista12.Clear();
			CartelLista13.Clear();
			CartelLista14.Clear();
			CartelLista15.Clear();
			CartelLista16.Clear();
			CartelLista17.Clear();
			CartelLista18.Clear();
			CartelLista19.Clear();
			ArriboLista0.Clear();
			ArriboLista1.Clear();
			ArriboLista2.Clear();
			ArriboLista3.Clear();
			ArriboLista4.Clear();
			ArriboLista5.Clear();
			ArriboLista6.Clear();
			ArriboLista7.Clear();
			ArriboLista8.Clear();
			ArriboLista9.Clear();
			ArriboLista10.Clear();
			ArriboLista11.Clear();
			ArriboLista12.Clear();
			ArriboLista13.Clear();
			ArriboLista14.Clear();
			ArriboLista15.Clear();
			ArriboLista16.Clear();
			ArriboLista17.Clear();
			ArriboLista18.Clear();
			ArriboLista19.Clear();
			DestinoLista0.Clear();
			DestinoLista1.Clear();
			DestinoLista2.Clear();
			DestinoLista3.Clear();
			DestinoLista4.Clear();
			DestinoLista5.Clear();
			DestinoLista6.Clear();
			DestinoLista7.Clear();
			DestinoLista8.Clear();
			DestinoLista9.Clear();
			DestinoLista10.Clear();
			DestinoLista11.Clear();
			DestinoLista12.Clear();
			DestinoLista13.Clear();
			DestinoLista14.Clear();
			DestinoLista15.Clear();
			DestinoLista16.Clear();
			DestinoLista17.Clear();
			DestinoLista18.Clear();
			DestinoLista19.Clear();

		}

		if (Activacion.idPP0) {
			if (InternoLista0.Count == 0) {
				InternoLista0.Add ("Error Servicio");
				CartelLista0.Add ("Error Servicio");
				ArriboLista0.Add ("Error Servicio");
				DestinoLista0.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista0 [0];
				Cartel1.text = CartelLista0[0];
				Arribo1.text = ArriboLista0[0];
				Destino1.text =DestinoLista0[0];
			}
			if (InternoLista0.Count < 2) {
				InternoLista0.Add ("Error Servicio");
				CartelLista0.Add ("Error Servicio");
				ArriboLista0.Add ("Error Servicio");
				DestinoLista0.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista0 [1];
				Cartel2.text = CartelLista0[1];
				Arribo2.text = ArriboLista0[1];
				Destino2.text =DestinoLista0[1];
			}
			if (InternoLista0.Count < 3) {
				InternoLista0.Add ("Error Servicio");
				CartelLista0.Add ("Error Servicio");
				ArriboLista0.Add ("Error Servicio");
				DestinoLista0.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista0 [2];
				Cartel3.text = CartelLista0[2];
				Arribo3.text = ArriboLista0[2];
				Destino3.text =DestinoLista0[2];
			}
			if (InternoLista0.Count < 4) {
				InternoLista0.Add ("Error Servicio");
				CartelLista0.Add ("Error Servicio");
				ArriboLista0.Add ("Error Servicio");
				DestinoLista0.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista0 [3];
				Cartel4.text = CartelLista0[3];
				Arribo4.text = ArriboLista0[3];
				Destino4.text =DestinoLista0[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [0]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [0]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[0]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[0]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [0]);

			Activacion.idPP0 = false;
		}

		if (Activacion.idPP1) {
			if (InternoLista1.Count == 0) {
				InternoLista1.Add ("Error Servicio");
				CartelLista1.Add ("Error Servicio");
				ArriboLista1.Add ("Error Servicio");
				DestinoLista1.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista2 [0];
				Cartel1.text = CartelLista1[0];
				Arribo1.text = ArriboLista1[0];
				Destino1.text =DestinoLista1[0];
			}
			if (InternoLista1.Count < 2) {
				InternoLista1.Add ("Error Servicio");
				CartelLista1.Add ("Error Servicio");
				ArriboLista1.Add ("Error Servicio");
				DestinoLista1.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista1 [1];
				Cartel2.text = CartelLista1[1];
				Arribo2.text = ArriboLista1[1];
				Destino2.text =DestinoLista1[1];
			}
			if (InternoLista1.Count < 3) {
				InternoLista1.Add ("Error Servicio");
				CartelLista1.Add ("Error Servicio");
				ArriboLista1.Add ("Error Servicio");
				DestinoLista1.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista1 [2];
				Cartel3.text = CartelLista1[2];
				Arribo3.text = ArriboLista1[2];
				Destino3.text =DestinoLista1[2];
			}
			if (InternoLista1.Count < 4) {
				InternoLista1.Add ("Error Servicio");
				CartelLista1.Add ("Error Servicio");
				ArriboLista1.Add ("Error Servicio");
				DestinoLista1.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista1 [3];
				Cartel4.text = CartelLista1[3];
				Arribo4.text = ArriboLista1[3];
				Destino4.text =DestinoLista1[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [1]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [1]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[1]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[1]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [1]);

			Activacion.idPP1 = false;
		}

		if (Activacion.idPP2) {
			if (InternoLista2.Count == 0) {
				InternoLista2.Add ("Error Servicio");
				CartelLista2.Add ("Error Servicio");
				ArriboLista2.Add ("Error Servicio");
				DestinoLista2.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista2 [0];
				Cartel1.text = CartelLista2[0];
				Arribo1.text = ArriboLista2[0];
				Destino1.text =DestinoLista2[0];
			}
			if (InternoLista2.Count < 2) {
				InternoLista2.Add ("Error Servicio");
				CartelLista2.Add ("Error Servicio");
				ArriboLista2.Add ("Error Servicio");
				DestinoLista2.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista2 [1];
				Cartel2.text = CartelLista2[1];
				Arribo2.text = ArriboLista2[1];
				Destino2.text =DestinoLista2[1];
			}
			if (InternoLista2.Count < 3) {
				InternoLista2.Add ("Error Servicio");
				CartelLista2.Add ("Error Servicio");
				ArriboLista2.Add ("Error Servicio");
				DestinoLista2.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista2 [2];
				Cartel3.text = CartelLista2[2];
				Arribo3.text = ArriboLista2[2];
				Destino3.text =DestinoLista2[2];
			}
			if (InternoLista2.Count < 4) {
				InternoLista2.Add ("Error Servicio");
				CartelLista2.Add ("Error Servicio");
				ArriboLista2.Add ("Error Servicio");
				DestinoLista2.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista2 [3];
				Cartel4.text = CartelLista2[3];
				Arribo4.text = ArriboLista2[3];
				Destino4.text =DestinoLista2[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [2]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [2]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[2]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[2]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [2]);

			Activacion.idPP2 = false;
		}
		if (Activacion.idPP3) {
			if (InternoLista3.Count == 0) {
				InternoLista3.Add ("Error Servicio");
				CartelLista3.Add ("Error Servicio");
				ArriboLista3.Add ("Error Servicio");
				DestinoLista3.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista3 [0];
				Cartel1.text = CartelLista3[0];
				Arribo1.text = ArriboLista3[0];
				Destino1.text =DestinoLista3[0];
			}
			if (InternoLista3.Count < 2) {
				InternoLista3.Add ("Error Servicio");
				CartelLista3.Add ("Error Servicio");
				ArriboLista3.Add ("Error Servicio");
				DestinoLista3.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista3 [1];
				Cartel2.text = CartelLista3[1];
				Arribo2.text = ArriboLista3[1];
				Destino2.text =DestinoLista3[1];
			}
			if (InternoLista3.Count < 3) {
				InternoLista3.Add ("Error Servicio");
				CartelLista3.Add ("Error Servicio");
				ArriboLista3.Add ("Error Servicio");
				DestinoLista3.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista3 [2];
				Cartel3.text = CartelLista3[2];
				Arribo3.text = ArriboLista3[2];
				Destino3.text =DestinoLista3[2];
			}
			if (InternoLista3.Count < 4) {
				InternoLista3.Add ("Error Servicio");
				CartelLista3.Add ("Error Servicio");
				ArriboLista3.Add ("Error Servicio");
				DestinoLista3.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista3 [3];
				Cartel4.text = CartelLista3[3];
				Arribo4.text = ArriboLista3[3];
				Destino4.text =DestinoLista3[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [3]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [3]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[3]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[3]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [3]);

			Activacion.idPP3 = false;
		}
		if (Activacion.idPP4) {
			if (InternoLista4.Count == 0) {
				InternoLista4.Add ("Error Servicio");
				CartelLista4.Add ("Error Servicio");
				ArriboLista4.Add ("Error Servicio");
				DestinoLista4.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista4 [0];
				Cartel1.text = CartelLista4[0];
				Arribo1.text = ArriboLista4[0];
				Destino1.text =DestinoLista4[0];
			}
			if (InternoLista4.Count < 2) {
				InternoLista4.Add ("Error Servicio");
				CartelLista4.Add ("Error Servicio");
				ArriboLista4.Add ("Error Servicio");
				DestinoLista4.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista4 [1];
				Cartel2.text = CartelLista4[1];
				Arribo2.text = ArriboLista4[1];
				Destino2.text =DestinoLista4[1];
			}
			if (InternoLista4.Count < 3) {
				InternoLista4.Add ("Error Servicio");
				CartelLista4.Add ("Error Servicio");
				ArriboLista4.Add ("Error Servicio");
				DestinoLista4.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista4 [2];
				Cartel3.text = CartelLista4[2];
				Arribo3.text = ArriboLista4[2];
				Destino3.text =DestinoLista4[2];
			}
			if (InternoLista4.Count < 4) {
				InternoLista4.Add ("Error Servicio");
				CartelLista4.Add ("Error Servicio");
				ArriboLista4.Add ("Error Servicio");
				DestinoLista4.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista4 [3];
				Cartel4.text = CartelLista4[3];
				Arribo4.text = ArriboLista4[3];
				Destino4.text =DestinoLista4[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [4]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [4]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[4]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[4]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [4]);

			Activacion.idPP4 = false;
		}
		if (Activacion.idPP5) {
			if (InternoLista5.Count == 0) {
				InternoLista5.Add ("Error Servicio");
				CartelLista5.Add ("Error Servicio");
				ArriboLista5.Add ("Error Servicio");
				DestinoLista5.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista5[0];
				Cartel1.text = CartelLista5[0];
				Arribo1.text = ArriboLista5[0];
				Destino1.text =DestinoLista5[0];
			}
			if (InternoLista5.Count < 2) {
				InternoLista5.Add ("Error Servicio");
				CartelLista5.Add ("Error Servicio");
				ArriboLista5.Add ("Error Servicio");
				DestinoLista5.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista5 [1];
				Cartel2.text = CartelLista5[1];
				Arribo2.text = ArriboLista5[1];
				Destino2.text =DestinoLista5[1];
			}
			if (InternoLista5.Count < 3) {
				InternoLista5.Add ("Error Servicio");
				CartelLista5.Add ("Error Servicio");
				ArriboLista5.Add ("Error Servicio");
				DestinoLista5.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista5 [2];
				Cartel3.text = CartelLista5[2];
				Arribo3.text = ArriboLista5[2];
				Destino3.text =DestinoLista5[2];
			}
			if (InternoLista5.Count < 4) {
				InternoLista5.Add ("Error Servicio");
				CartelLista5.Add ("Error Servicio");
				ArriboLista5.Add ("Error Servicio");
				DestinoLista5.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista5 [3];
				Cartel4.text = CartelLista5[3];
				Arribo4.text = ArriboLista5[3];
				Destino4.text =DestinoLista5[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [5]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [5]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[5]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[5]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [5]);

			Activacion.idPP5 = false;
		}
		if (Activacion.idPP6) {
			if (InternoLista6.Count == 0) {
				InternoLista6.Add ("Error Servicio");
				CartelLista6.Add ("Error Servicio");
				ArriboLista6.Add ("Error Servicio");
				DestinoLista6.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista6[0];
				Cartel1.text = CartelLista6[0];
				Arribo1.text = ArriboLista6[0];
				Destino1.text =DestinoLista6[0];
			}
			if (InternoLista6.Count < 2) {
				InternoLista6.Add ("Error Servicio");
				CartelLista6.Add ("Error Servicio");
				ArriboLista6.Add ("Error Servicio");
				DestinoLista6.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista6 [1];
				Cartel2.text = CartelLista6[1];
				Arribo2.text = ArriboLista6[1];
				Destino2.text =DestinoLista6[1];
			}
			if (InternoLista6.Count < 3) {
				InternoLista6.Add ("Error Servicio");
				CartelLista6.Add ("Error Servicio");
				ArriboLista6.Add ("Error Servicio");
				DestinoLista6.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista6 [2];
				Cartel3.text = CartelLista6[2];
				Arribo3.text = ArriboLista6[2];
				Destino3.text =DestinoLista6[2];
			}
			if (InternoLista6.Count < 4) {
				InternoLista6.Add ("Error Servicio");
				CartelLista6.Add ("Error Servicio");
				ArriboLista6.Add ("Error Servicio");
				DestinoLista6.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista6 [3];
				Cartel4.text = CartelLista6[3];
				Arribo4.text = ArriboLista6[3];
				Destino4.text =DestinoLista6[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [6]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [6]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[6]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[6]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [6]);

			Activacion.idPP6 = false;
		}
		if (Activacion.idPP7) {
			if (InternoLista7.Count == 0) {
				InternoLista7.Add ("Error Servicio");
				CartelLista7.Add ("Error Servicio");
				ArriboLista7.Add ("Error Servicio");
				DestinoLista7.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista7[0];
				Cartel1.text = CartelLista7[0];
				Arribo1.text = ArriboLista7[0];
				Destino1.text =DestinoLista7[0];
			}
			if (InternoLista7.Count < 2) {
				InternoLista7.Add ("Error Servicio");
				CartelLista7.Add ("Error Servicio");
				ArriboLista7.Add ("Error Servicio");
				DestinoLista7.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista7 [1];
				Cartel2.text = CartelLista7[1];
				Arribo2.text = ArriboLista7[1];
				Destino2.text =DestinoLista7[1];
			}
			if (InternoLista7.Count < 3) {
				InternoLista7.Add ("Error Servicio");
				CartelLista7.Add ("Error Servicio");
				ArriboLista7.Add ("Error Servicio");
				DestinoLista7.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista7 [2];
				Cartel3.text = CartelLista7[2];
				Arribo3.text = ArriboLista7[2];
				Destino3.text =DestinoLista7[2];
			}
			if (InternoLista7.Count < 4) {
				InternoLista7.Add ("Error Servicio");
				CartelLista7.Add ("Error Servicio");
				ArriboLista7.Add ("Error Servicio");
				DestinoLista7.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista7 [3];
				Cartel4.text = CartelLista7[3];
				Arribo4.text = ArriboLista7[3];
				Destino4.text =DestinoLista7[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [7]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [7]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[7]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[7]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [7]);

			Activacion.idPP7 = false;
		}
		if (Activacion.idPP8) {
			if (InternoLista8.Count == 0) {
				InternoLista8.Add ("Error Servicio");
				CartelLista8.Add ("Error Servicio");
				ArriboLista8.Add ("Error Servicio");
				DestinoLista8.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista8[0];
				Cartel1.text = CartelLista8[0];
				Arribo1.text = ArriboLista8[0];
				Destino1.text =DestinoLista8[0];
			}
			if (InternoLista8.Count < 2) {
				InternoLista8.Add ("Error Servicio");
				CartelLista8.Add ("Error Servicio");
				ArriboLista8.Add ("Error Servicio");
				DestinoLista8.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista8 [1];
				Cartel2.text = CartelLista8[1];
				Arribo2.text = ArriboLista8[1];
				Destino2.text =DestinoLista8[1];
			}
			if (InternoLista8.Count < 3) {
				InternoLista8.Add ("Error Servicio");
				CartelLista8.Add ("Error Servicio");
				ArriboLista8.Add ("Error Servicio");
				DestinoLista8.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista8 [2];
				Cartel3.text = CartelLista8[2];
				Arribo3.text = ArriboLista8[2];
				Destino3.text =DestinoLista8[2];
			}
			if (InternoLista8.Count < 4) {
				InternoLista8.Add ("Error Servicio");
				CartelLista8.Add ("Error Servicio");
				ArriboLista8.Add ("Error Servicio");
				DestinoLista8.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista8 [3];
				Cartel4.text = CartelLista8[3];
				Arribo4.text = ArriboLista8[3];
				Destino4.text =DestinoLista8[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [8]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [8]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[8]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[8]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [8]);

			Activacion.idPP8 = false;
		}
		if (Activacion.idPP9) {
			if (InternoLista9.Count == 0) {
				InternoLista9.Add ("Error Servicio");
				CartelLista9.Add ("Error Servicio");
				ArriboLista9.Add ("Error Servicio");
				DestinoLista9.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista9[0];
				Cartel1.text = CartelLista9[0];
				Arribo1.text = ArriboLista9[0];
				Destino1.text =DestinoLista9[0];
			}
			if (InternoLista9.Count < 2) {
				InternoLista9.Add ("Error Servicio");
				CartelLista9.Add ("Error Servicio");
				ArriboLista9.Add ("Error Servicio");
				DestinoLista9.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista9 [1];
				Cartel2.text = CartelLista9[1];
				Arribo2.text = ArriboLista9[1];
				Destino2.text =DestinoLista9[1];
			}
			if (InternoLista9.Count < 3) {
				InternoLista9.Add ("Error Servicio");
				CartelLista9.Add ("Error Servicio");
				ArriboLista9.Add ("Error Servicio");
				DestinoLista9.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista9 [2];
				Cartel3.text = CartelLista9[2];
				Arribo3.text = ArriboLista9[2];
				Destino3.text =DestinoLista9[2];
			}
			if (InternoLista9.Count < 4) {
				InternoLista9.Add ("Error Servicio");
				CartelLista9.Add ("Error Servicio");
				ArriboLista9.Add ("Error Servicio");
				DestinoLista9.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista9 [3];
				Cartel4.text = CartelLista9[3];
				Arribo4.text = ArriboLista9[3];
				Destino4.text =DestinoLista9[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [9]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [9]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[9]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[9]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [9]);

			Activacion.idPP9 = false;
		}
		if (Activacion.idPP10) {
			if (InternoLista10.Count == 0) {
				InternoLista10.Add ("Error Servicio");
				CartelLista10.Add ("Error Servicio");
				ArriboLista10.Add ("Error Servicio");
				DestinoLista10.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista10[0];
				Cartel1.text = CartelLista10[0];
				Arribo1.text = ArriboLista10[0];
				Destino1.text =DestinoLista10[0];
			}
			if (InternoLista10.Count < 2) {
				InternoLista10.Add ("Error Servicio");
				CartelLista10.Add ("Error Servicio");
				ArriboLista10.Add ("Error Servicio");
				DestinoLista10.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista10 [1];
				Cartel2.text = CartelLista10[1];
				Arribo2.text = ArriboLista10[1];
				Destino2.text =DestinoLista10[1];
			}
			if (InternoLista10.Count < 3) {
				InternoLista10.Add ("Error Servicio");
				CartelLista10.Add ("Error Servicio");
				ArriboLista10.Add ("Error Servicio");
				DestinoLista10.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista10 [2];
				Cartel3.text = CartelLista10[2];
				Arribo3.text = ArriboLista10[2];
				Destino3.text =DestinoLista10[2];
			}
			if (InternoLista10.Count < 4) {
				InternoLista10.Add ("Error Servicio");
				CartelLista10.Add ("Error Servicio");
				ArriboLista10.Add ("Error Servicio");
				DestinoLista10.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista10 [3];
				Cartel4.text = CartelLista10[3];
				Arribo4.text = ArriboLista10[3];
				Destino4.text =DestinoLista10[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [10]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [10]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[10]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[10]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [10]);

			Activacion.idPP10 = false;
		}
		if (Activacion.idPP11) {
			if (InternoLista11.Count == 0) {
				InternoLista11.Add ("Error Servicio");
				CartelLista11.Add ("Error Servicio");
				ArriboLista11.Add ("Error Servicio");
				DestinoLista11.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista11[0];
				Cartel1.text = CartelLista11[0];
				Arribo1.text = ArriboLista11[0];
				Destino1.text =DestinoLista11[0];
			}
			if (InternoLista11.Count < 2) {
				InternoLista11.Add ("Error Servicio");
				CartelLista11.Add ("Error Servicio");
				ArriboLista11.Add ("Error Servicio");
				DestinoLista11.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista11 [1];
				Cartel2.text = CartelLista11[1];
				Arribo2.text = ArriboLista11[1];
				Destino2.text =DestinoLista11[1];
			}
			if (InternoLista11.Count < 3) {
				InternoLista11.Add ("Error Servicio");
				CartelLista11.Add ("Error Servicio");
				ArriboLista11.Add ("Error Servicio");
				DestinoLista11.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista11 [2];
				Cartel3.text = CartelLista11[2];
				Arribo3.text = ArriboLista11[2];
				Destino3.text =DestinoLista11[2];
			}
			if (InternoLista11.Count < 4) {
				InternoLista11.Add ("Error Servicio");
				CartelLista11.Add ("Error Servicio");
				ArriboLista11.Add ("Error Servicio");
				DestinoLista11.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista11 [3];
				Cartel4.text = CartelLista11[3];
				Arribo4.text = ArriboLista11[3];
				Destino4.text =DestinoLista11[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [11]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [11]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[11]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[11]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [11]);

			Activacion.idPP11 = false;
		}
		if (Activacion.idPP12) {
			if (InternoLista12.Count == 0) {
				InternoLista12.Add ("Error Servicio");
				CartelLista12.Add ("Error Servicio");
				ArriboLista12.Add ("Error Servicio");
				DestinoLista12.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista12[0];
				Cartel1.text = CartelLista12[0];
				Arribo1.text = ArriboLista12[0];
				Destino1.text =DestinoLista12[0];
			}
			if (InternoLista12.Count < 2) {
				InternoLista12.Add ("Error Servicio");
				CartelLista12.Add ("Error Servicio");
				ArriboLista12.Add ("Error Servicio");
				DestinoLista12.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista12 [1];
				Cartel2.text = CartelLista12[1];
				Arribo2.text = ArriboLista12[1];
				Destino2.text =DestinoLista12[1];
			}
			if (InternoLista12.Count < 3) {
				InternoLista12.Add ("Error Servicio");
				CartelLista12.Add ("Error Servicio");
				ArriboLista12.Add ("Error Servicio");
				DestinoLista12.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista12 [2];
				Cartel3.text = CartelLista12[2];
				Arribo3.text = ArriboLista12[2];
				Destino3.text =DestinoLista12[2];
			}
			if (InternoLista12.Count < 4) {
				InternoLista12.Add ("Error Servicio");
				CartelLista12.Add ("Error Servicio");
				ArriboLista12.Add ("Error Servicio");
				DestinoLista12.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista12 [3];
				Cartel4.text = CartelLista12[3];
				Arribo4.text = ArriboLista12[3];
				Destino4.text =DestinoLista12[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [12]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [12]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[12]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[12]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [12]);

			Activacion.idPP12 = false;
		}
		if (Activacion.idPP13) {
			if (InternoLista13.Count == 0) {
				InternoLista13.Add ("Error Servicio");
				CartelLista13.Add ("Error Servicio");
				ArriboLista13.Add ("Error Servicio");
				DestinoLista13.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista13[0];
				Cartel1.text = CartelLista13[0];
				Arribo1.text = ArriboLista13[0];
				Destino1.text =DestinoLista13[0];
			}
			if (InternoLista13.Count < 2) {
				InternoLista13.Add ("Error Servicio");
				CartelLista13.Add ("Error Servicio");
				ArriboLista13.Add ("Error Servicio");
				DestinoLista13.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista13 [1];
				Cartel2.text = CartelLista13[1];
				Arribo2.text = ArriboLista13[1];
				Destino2.text =DestinoLista13[1];
			}
			if (InternoLista13.Count < 3) {
				InternoLista13.Add ("Error Servicio");
				CartelLista13.Add ("Error Servicio");
				ArriboLista13.Add ("Error Servicio");
				DestinoLista13.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista13 [2];
				Cartel3.text = CartelLista13[2];
				Arribo3.text = ArriboLista13[2];
				Destino3.text =DestinoLista13[2];
			}
			if (InternoLista13.Count < 4) {
				InternoLista13.Add ("Error Servicio");
				CartelLista13.Add ("Error Servicio");
				ArriboLista13.Add ("Error Servicio");
				DestinoLista13.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista13 [3];
				Cartel4.text = CartelLista13[3];
				Arribo4.text = ArriboLista13[3];
				Destino4.text =DestinoLista13[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [13]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [13]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[13]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[13]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [13]);

			Activacion.idPP13 = false;
		}
		if (Activacion.idPP14) {
			if (InternoLista14.Count == 0) {
				InternoLista14.Add ("Error Servicio");
				CartelLista14.Add ("Error Servicio");
				ArriboLista14.Add ("Error Servicio");
				DestinoLista14.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista14[0];
				Cartel1.text = CartelLista14[0];
				Arribo1.text = ArriboLista14[0];
				Destino1.text =DestinoLista14[0];
			}
			if (InternoLista14.Count < 2) {
				InternoLista14.Add ("Error Servicio");
				CartelLista14.Add ("Error Servicio");
				ArriboLista14.Add ("Error Servicio");
				DestinoLista14.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista14 [1];
				Cartel2.text = CartelLista14[1];
				Arribo2.text = ArriboLista14[1];
				Destino2.text =DestinoLista14[1];
			}
			if (InternoLista14.Count < 3) {
				InternoLista14.Add ("Error Servicio");
				CartelLista14.Add ("Error Servicio");
				ArriboLista14.Add ("Error Servicio");
				DestinoLista14.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista14 [2];
				Cartel3.text = CartelLista14[2];
				Arribo3.text = ArriboLista14[2];
				Destino3.text =DestinoLista14[2];
			}
			if (InternoLista14.Count < 4) {
				InternoLista14.Add ("Error Servicio");
				CartelLista14.Add ("Error Servicio");
				ArriboLista14.Add ("Error Servicio");
				DestinoLista14.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista14 [3];
				Cartel4.text = CartelLista14[3];
				Arribo4.text = ArriboLista14[3];
				Destino4.text =DestinoLista14[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [14]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [14]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[14]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[14]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [14]);

			Activacion.idPP14 = false;
		}
		if (Activacion.idPP15) {
			if (InternoLista15.Count == 0) {
				InternoLista15.Add ("Error Servicio");
				CartelLista15.Add ("Error Servicio");
				ArriboLista15.Add ("Error Servicio");
				DestinoLista15.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista15[0];
				Cartel1.text = CartelLista15[0];
				Arribo1.text = ArriboLista15[0];
				Destino1.text =DestinoLista15[0];
			}
			if (InternoLista15.Count < 2) {
				InternoLista15.Add ("Error Servicio");
				CartelLista15.Add ("Error Servicio");
				ArriboLista15.Add ("Error Servicio");
				DestinoLista15.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista15 [1];
				Cartel2.text = CartelLista15[1];
				Arribo2.text = ArriboLista15[1];
				Destino2.text =DestinoLista15[1];
			}
			if (InternoLista15.Count < 3) {
				InternoLista15.Add ("Error Servicio");
				CartelLista15.Add ("Error Servicio");
				ArriboLista15.Add ("Error Servicio");
				DestinoLista15.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista15 [2];
				Cartel3.text = CartelLista15[2];
				Arribo3.text = ArriboLista15[2];
				Destino3.text =DestinoLista15[2];
			}
			if (InternoLista15.Count < 4) {
				InternoLista15.Add ("Error Servicio");
				CartelLista15.Add ("Error Servicio");
				ArriboLista15.Add ("Error Servicio");
				DestinoLista15.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista15 [3];
				Cartel4.text = CartelLista15[3];
				Arribo4.text = ArriboLista15[3];
				Destino4.text =DestinoLista15[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [15]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [15]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[15]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[15]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [15]);

			Activacion.idPP15 = false;
		}
		if (Activacion.idPP16) {
			if (InternoLista16.Count == 0) {
				InternoLista16.Add ("Error Servicio");
				CartelLista16.Add ("Error Servicio");
				ArriboLista16.Add ("Error Servicio");
				DestinoLista16.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista16[0];
				Cartel1.text = CartelLista16[0];
				Arribo1.text = ArriboLista16[0];
				Destino1.text =DestinoLista16[0];
			}
			if (InternoLista16.Count < 2) {
				InternoLista16.Add ("Error Servicio");
				CartelLista16.Add ("Error Servicio");
				ArriboLista16.Add ("Error Servicio");
				DestinoLista16.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista16 [1];
				Cartel2.text = CartelLista16[1];
				Arribo2.text = ArriboLista16[1];
				Destino2.text =DestinoLista16[1];
			}
			if (InternoLista16.Count < 3) {
				InternoLista16.Add ("Error Servicio");
				CartelLista16.Add ("Error Servicio");
				ArriboLista16.Add ("Error Servicio");
				DestinoLista16.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista16 [2];
				Cartel3.text = CartelLista16[2];
				Arribo3.text = ArriboLista16[2];
				Destino3.text =DestinoLista16[2];
			}
			if (InternoLista16.Count < 4) {
				InternoLista16.Add ("Error Servicio");
				CartelLista16.Add ("Error Servicio");
				ArriboLista16.Add ("Error Servicio");
				DestinoLista16.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista16 [3];
				Cartel4.text = CartelLista16[3];
				Arribo4.text = ArriboLista16[3];
				Destino4.text =DestinoLista16[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [16]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [16]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[16]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[16]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [16]);

			Activacion.idPP16 = false;
		}
		if (Activacion.idPP17) {
			if (InternoLista17.Count == 0) {
				InternoLista17.Add ("Error Servicio");
				CartelLista17.Add ("Error Servicio");
				ArriboLista17.Add ("Error Servicio");
				DestinoLista17.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista17[0];
				Cartel1.text = CartelLista17[0];
				Arribo1.text = ArriboLista17[0];
				Destino1.text =DestinoLista17[0];
			}
			if (InternoLista17.Count < 2) {
				InternoLista17.Add ("Error Servicio");
				CartelLista17.Add ("Error Servicio");
				ArriboLista17.Add ("Error Servicio");
				DestinoLista17.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista17 [1];
				Cartel2.text = CartelLista17[1];
				Arribo2.text = ArriboLista17[1];
				Destino2.text =DestinoLista17[1];
			}
			if (InternoLista17.Count < 3) {
				InternoLista17.Add ("Error Servicio");
				CartelLista17.Add ("Error Servicio");
				ArriboLista17.Add ("Error Servicio");
				DestinoLista17.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista17 [2];
				Cartel3.text = CartelLista17[2];
				Arribo3.text = ArriboLista17[2];
				Destino3.text =DestinoLista17[2];
			}
			if (InternoLista17.Count < 4) {
				InternoLista17.Add ("Error Servicio");
				CartelLista17.Add ("Error Servicio");
				ArriboLista17.Add ("Error Servicio");
				DestinoLista17.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista17 [3];
				Cartel4.text = CartelLista17[3];
				Arribo4.text = ArriboLista17[3];
				Destino4.text =DestinoLista17[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [17]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [17]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[17]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[17]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [17]);

			Activacion.idPP17 = false;
		}
		if (Activacion.idPP18) {
			if (InternoLista18.Count == 0) {
				InternoLista18.Add ("Error Servicio");
				CartelLista18.Add ("Error Servicio");
				ArriboLista18.Add ("Error Servicio");
				DestinoLista18.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista18[0];
				Cartel1.text = CartelLista18[0];
				Arribo1.text = ArriboLista18[0];
				Destino1.text =DestinoLista18[0];
			}
			if (InternoLista18.Count < 2) {
				InternoLista18.Add ("Error Servicio");
				CartelLista18.Add ("Error Servicio");
				ArriboLista18.Add ("Error Servicio");
				DestinoLista18.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista18 [1];
				Cartel2.text = CartelLista18[1];
				Arribo2.text = ArriboLista18[1];
				Destino2.text =DestinoLista18[1];
			}
			if (InternoLista18.Count < 3) {
				InternoLista18.Add ("Error Servicio");
				CartelLista18.Add ("Error Servicio");
				ArriboLista18.Add ("Error Servicio");
				DestinoLista18.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista18 [2];
				Cartel3.text = CartelLista18[2];
				Arribo3.text = ArriboLista18[2];
				Destino3.text =DestinoLista18[2];
			}
			if (InternoLista18.Count < 4) {
				InternoLista18.Add ("Error Servicio");
				CartelLista18.Add ("Error Servicio");
				ArriboLista18.Add ("Error Servicio");
				DestinoLista18.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista18 [3];
				Cartel4.text = CartelLista18[3];
				Arribo4.text = ArriboLista18[3];
				Destino4.text =DestinoLista18[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [18]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [18]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[18]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[18]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [18]);

			Activacion.idPP18 = false;
		}
		if (Activacion.idPP19) {
			if (InternoLista19.Count == 0) {
				InternoLista19.Add ("Error Servicio");
				CartelLista19.Add ("Error Servicio");
				ArriboLista19.Add ("Error Servicio");
				DestinoLista19.Add ("Error Servicio");
			} else {
				Interno1.text = InternoLista19[0];
				Cartel1.text = CartelLista19[0];
				Arribo1.text = ArriboLista19[0];
				Destino1.text =DestinoLista19[0];
			}
			if (InternoLista19.Count < 2) {
				InternoLista19.Add ("Error Servicio");
				CartelLista19.Add ("Error Servicio");
				ArriboLista19.Add ("Error Servicio");
				DestinoLista19.Add ("Error Servicio");
			} else {
				Interno2.text = InternoLista19 [1];
				Cartel2.text = CartelLista19[1];
				Arribo2.text = ArriboLista19[1];
				Destino2.text =DestinoLista19[1];
			}
			if (InternoLista19.Count < 3) {
				InternoLista19.Add ("Error Servicio");
				CartelLista19.Add ("Error Servicio");
				ArriboLista19.Add ("Error Servicio");
				DestinoLista19.Add ("Error Servicio");
			} else {
				Interno3.text = InternoLista19 [2];
				Cartel3.text = CartelLista19[2];
				Arribo3.text = ArriboLista19[2];
				Destino3.text =DestinoLista19[2];
			}
			if (InternoLista19.Count < 4) {
				InternoLista19.Add ("Error Servicio");
				CartelLista19.Add ("Error Servicio");
				ArriboLista19.Add ("Error Servicio");
				DestinoLista19.Add ("Error Servicio");
			} else {
				Interno4.text = InternoLista19 [3];
				Cartel4.text = CartelLista19[3];
				Arribo4.text = ArriboLista19[3];
				Destino4.text =DestinoLista19[3];
			}
			PlayerPrefs.SetInt("TempLineaId", idLineaList [19]);
			PlayerPrefs.SetInt("TempParadaId", idParadaList [19]);
			PlayerPrefs.SetFloat ("LatitudTemp", Latitudes[19]);
			PlayerPrefs.SetFloat ("LongitudTemp",Longitudes[19]);
			ContadorListado = PlayerPrefs.GetInt ("ContadorListado");
			Agregar (Descripciones [19]);

			Activacion.idPP19 = false;
		}
	}


	public IEnumerator Parseador()
	{
		Debug.Log ("Hola");
		Mapas.zoom = 16;
		Mapas.zoom = 15;
		//Load JSON data from a URL
		//string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson=-34.608&longUnicaJson=-58.392&metros=200";
		string url ="http://www.bondicom.com.ar/responders/bondicomResponder.aspx?latUnicaJson="+GeoNativo.LatMia+"&longUnicaJson="+GeoNativo.LongMia+"&metros=200";
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
			Descripciones.Add (prediccion.descripcion);
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
			if (i == 6) {
				InternoLista6.Add (prediccionPP.i.ToString ());
				CartelLista6.Add (prediccionPP.cartel.ToString ());
				ArriboLista6.Add (prediccionPP.t.ToString ());
				DestinoLista6.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 7) {
				InternoLista7.Add (prediccionPP.i.ToString ());
				CartelLista7.Add (prediccionPP.cartel.ToString ());
				ArriboLista7.Add (prediccionPP.t.ToString ());
				DestinoLista7.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 8) {
				InternoLista8.Add (prediccionPP.i.ToString ());
				CartelLista8.Add (prediccionPP.cartel.ToString ());
				ArriboLista8.Add (prediccionPP.t.ToString ());
				DestinoLista8.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 9) {
				InternoLista9.Add (prediccionPP.i.ToString ());
				CartelLista9.Add (prediccionPP.cartel.ToString ());
				ArriboLista9.Add (prediccionPP.t.ToString ());
				DestinoLista9.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 10) {
				InternoLista10.Add (prediccionPP.i.ToString ());
				CartelLista10.Add (prediccionPP.cartel.ToString ());
				ArriboLista10.Add (prediccionPP.t.ToString ());
				DestinoLista10.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 11) {
				InternoLista11.Add (prediccionPP.i.ToString ());
				CartelLista11.Add (prediccionPP.cartel.ToString ());
				ArriboLista11.Add (prediccionPP.t.ToString ());
				DestinoLista11.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 12) {
				InternoLista12.Add (prediccionPP.i.ToString ());
				CartelLista12.Add (prediccionPP.cartel.ToString ());
				ArriboLista12.Add (prediccionPP.t.ToString ());
				DestinoLista12.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 13) {
				InternoLista13.Add (prediccionPP.i.ToString ());
				CartelLista13.Add (prediccionPP.cartel.ToString ());
				ArriboLista13.Add (prediccionPP.t.ToString ());
				DestinoLista13.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 14) {
				InternoLista14.Add (prediccionPP.i.ToString ());
				CartelLista14.Add (prediccionPP.cartel.ToString ());
				ArriboLista14.Add (prediccionPP.t.ToString ());
				DestinoLista14.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 15) {
				InternoLista15.Add (prediccionPP.i.ToString ());
				CartelLista15.Add (prediccionPP.cartel.ToString ());
				ArriboLista15.Add (prediccionPP.t.ToString ());
				DestinoLista15.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 16) {
				InternoLista16.Add (prediccionPP.i.ToString ());
				CartelLista16.Add (prediccionPP.cartel.ToString ());
				ArriboLista16.Add (prediccionPP.t.ToString ());
				DestinoLista16.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 17) {
				InternoLista17.Add (prediccionPP.i.ToString ());
				CartelLista17.Add (prediccionPP.cartel.ToString ());
				ArriboLista17.Add (prediccionPP.t.ToString ());
				DestinoLista17.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 18) {
				InternoLista18.Add (prediccionPP.i.ToString ());
				CartelLista18.Add (prediccionPP.cartel.ToString ());
				ArriboLista18.Add (prediccionPP.t.ToString ());
				DestinoLista18.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			if (i == 19) {
				InternoLista19.Add (prediccionPP.i.ToString ());
				CartelLista19.Add (prediccionPP.cartel.ToString ());
				ArriboLista19.Add (prediccionPP.t.ToString ());
				DestinoLista19.Add (prediccionPP.hacia.ToString ());
				TempArrayPP = i;
			}
			//PadreInternoLista.Add (InternoLista);
		}
//		Debug.Log("Lista: " + PadreInternoLista[0][2]);//Primero Lista, Segundo Posicion
//		Debug.Log("Lista: " + PadreInternoLista[1][2]);
//		Debug.Log ("Lista: " + PadreInternoLista [2] [2]);
//		Debug.Log ("Lista: " + PadreInternoLista [3] [2]);
	}

	public void Agregar(string Nombre){

		if (ContadorListado == 0) {
			PlayerPrefs.SetString ("PPL0", Nombre);
			LineaJson.agregando1 = true;
			PlayerPrefs.SetInt ("Activo1", 1);
		}
		if (ContadorListado == 1) {
			PlayerPrefs.SetString ("PPL1", Nombre);
			LineaJson.agregando2 = true;
			PlayerPrefs.SetInt ("Activo2", 1);
		}
		if (ContadorListado == 2) {
			PlayerPrefs.SetString ("PPL2", Nombre);
			LineaJson.agregando3 = true;
			PlayerPrefs.SetInt ("Activo3", 1);
		}
		if (ContadorListado == 3) {
			PlayerPrefs.SetString ("PPL3", Nombre);
			LineaJson.agregando4 = true;
			PlayerPrefs.SetInt ("Activo4", 1);
		}
		if (ContadorListado == 4) {
			PlayerPrefs.SetString ("PPL4", Nombre);
			LineaJson.agregando5 = true;
			PlayerPrefs.SetInt ("Activo5", 1);
		}
		if (ContadorListado == 5) {
			PlayerPrefs.SetString ("PPL5", Nombre);
			LineaJson.agregando6 = true;
			PlayerPrefs.SetInt ("Activo6", 1);
		}
		if (ContadorListado >= 6) {
			PlayerPrefs.SetString ("NewPP", Nombre);
			LineaJson.agregandoNew = true;
		}
	}
}
