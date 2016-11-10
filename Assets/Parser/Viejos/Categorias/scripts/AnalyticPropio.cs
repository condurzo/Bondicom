using UnityEngine;
using System.Collections;

public class AnalyticPropio : MonoBehaviour {

	//**************************************************************************************************
	// Desarrollado por Gerardo Santisteban Serra
	// Libreria Contador de Visitas ... Actualizado
	// postURL = "http://www.qatukum.com/maxi-postName.php";
	// getURL  ="http://www.qatukum.com/maxi-getName.php";
	// Administrador : http://www.qatukum.com/maxi-admin.php
	// procedimiento:  GeralCounterWeb (<nombre de la variable-texto6>,<detalle de la variable-texto20>)
	//**************************************************************************************************

	public static string postURL = "http://www.qatukum.com/maxi-postName.php";
	public static string getURL  ="http://www.qatukum.com/maxi-getName.php";

	public static string nombre;
	public static bool activo;
	public string Codigo;

	void Update(){
		if (activo) {
			EnviarDatos ();
			activo = false;
		}
	}


	public void CmdButton(){
		Invoke ("EnviarDatos", 1);
	}

	void EnviarDatos(){
		GeralCounterWeb (nombre, nombre);
	}

	private void GeralCounterWeb(string CODE,string DETA){
		StartCoroutine (CreateKey(CODE,DETA));
		StartCoroutine (ActualizaDATOS(CODE));
	}


	private IEnumerator CreateKey(string CODE, string DETA){
		WWW getname = new WWW (getURL + "?code=" + WWW.EscapeURL (CODE.ToString ()) + "&deta=" + WWW.EscapeURL (DETA.ToString ()));
		yield return getname;
		if (getname.text.Trim () == "ok") {
			PlayerPrefs.SetInt (CODE, 0);
		}
		if (getname.text.Trim () == "error") {
			print ("Ya esta Tiene Registro :" + CODE);

		}
	}

	private IEnumerator ActualizaDATOS(string  CODE){
		int pivot;
		pivot=PlayerPrefs.GetInt (CODE);
		pivot++;
		PlayerPrefs.SetInt (CODE, pivot);
		WWW postname = new WWW (postURL+"?code="+WWW.EscapeURL(CODE.ToString())+"&conta="+WWW.EscapeURL(pivot.ToString()));
		yield return postname;
		if (postname.text.Trim()=="ok") {
			PlayerPrefs.SetInt(CODE,0);
		}
		if (postname.text=="error")
		{
			print("No exite Codigo :" + CODE);
		}	
	}

}

	



	


