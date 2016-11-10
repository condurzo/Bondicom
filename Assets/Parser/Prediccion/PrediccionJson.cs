using UnityEngine;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PrediccionJson : MonoBehaviour {
	
	public OnlineMaps Mapas;

	IEnumerator Start()
	{
		Mapas.zoom = 15;
		Mapas.zoom = 16;
		//Load JSON data from a URL
		string url = "www.bondicom.com.ar/responders/bondicomResponder.aspx?latitudJson="+GeoNativo.LatMia+"&longitudJson="+GeoNativo.LongMia+"&metros=200";
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

			prediccion.cartel = jsonPrediccion["row"][i]["cartel"].ToString();
			prediccion.code = Convert.ToInt16(jsonPrediccion["row"][i]["code"].ToString());
			prediccion.descripcion = jsonPrediccion["row"][i]["descripcion"].ToString();
			prediccion.fkEmpresa = Convert.ToInt16(jsonPrediccion["row"][i]["fkEmpresa"].ToString());
			prediccion.fkLinea = Convert.ToInt16(jsonPrediccion["row"][i]["fkLinea"].ToString());
			prediccion.lat = jsonPrediccion["row"][i]["lat"].ToString();
			prediccion.lon = jsonPrediccion["row"][i]["lon"].ToString();

			Debug.Log ("Cartel: " + prediccion.cartel);
			Debug.Log ("Cartel: " + prediccion.code);
			Debug.Log ("Cartel: " + prediccion.descripcion);
			Debug.Log ("Cartel: " + prediccion.fkEmpresa);
			Debug.Log ("Cartel: " + prediccion.fkLinea);
			Debug.Log ("Cartel: " + prediccion.lat);
			Debug.Log ("Cartel: " + prediccion.lon);

		}
	}



}
