using UnityEngine;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class ParadaJson : MonoBehaviour
{
	public Dropdown Maindropdown;

	public Text	text;
	public string[] parada;

	IEnumerator Start()
	{
		//Load JSON data from a URL
		string url = "http://www.bondicom.com.ar/responders/bondicomResponder.aspx?paradasJson=244";
		WWW www = new WWW(url);

		//Load the data and yield (wait) till it's ready before we continue executing the rest of this method.
		yield return www;
		if (www.error == null)
		{
			//Sucessfully loaded the JSON string
			Debug.Log("Parada" + www.data);

			//Process books found in JSON file
			ProcessParada(www.data);
		}
		else
		{
			Debug.Log("ERROR: " + www.error);
		}

	}

	//Converts a JSON string into Book objects and shows a book out of it on the screen
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

			Maindropdown.options.Add (new Dropdown.OptionData() {text=parada.Descripcion});
			//itemBase.onValueChanged.AddListener (CrearBtn);

		}
	}




}


