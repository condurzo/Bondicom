using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GeoNativo : MonoBehaviour {
	public Text Texto;
	public static double Lat;
	public static double Lon;
	public static bool listo;
	public Vector2 size;
	public float Latitud;
	public float Longitud;
	public static string LatMia;
	public static string LongMia;
	public bool Actualizo;
	public PrediccionJson Predi;



	IEnumerator Start() {
		if (!Input.location.isEnabledByUser)
			yield break;

		Input.location.Start();
		int maxWait = 20;
		while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0) {
			yield return new WaitForSeconds(1);
			maxWait--;
		}
		if (maxWait < 1) {
			print("Timed out");
			return false;
		}
		if (Input.location.status == LocationServiceStatus.Failed) {
			print ("Unable to determine device location");
			return false;
		} else
			listo = true;
			//Texto.text = "L: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude;
			print("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);
		//Input.location.Stop();


	}

	private void OnGUI(){
//		if (listo) {
//			if (GUI.Button (new Rect (Screen.width - 110, 40, 100, 20), "GEO"))
//				GeoLocation ();
//		}
	}

	public void ParadasCercanasBtn(){
		LatMia = "0";
		Actualizo = false;
	}

	public void GeoLocation(){
		OnlineMaps.latitude = Input.location.lastData.latitude;
		OnlineMaps.longitude = Input.location.lastData.longitude;
		LatMia = OnlineMaps.latitude.ToString ();
		LongMia = OnlineMaps.longitude.ToString();

		if ((LatMia != "")&&(LatMia != "0")){
			Predi.enabled = true;
			Actualizo = true;
		}
		//OnlineMaps.instance.AddMarker (size ,"Nombre-DNI");
		//listo = false;
	}
	void Update(){
		if (!Actualizo) {
			GeoLocation ();
//			Predi.enabled = true;
//			Actualizo = true;
		}
////		Latitud = (float)OnlineMaps.latitude;
////		Longitud = (float)OnlineMaps.longitude;
////		size = new Vector2 (Longitud, Latitud);
////		Texto.text = size.ToString ();
	}
}