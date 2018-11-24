using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour {

	public int tiempoInicial;
	public int tiempoTension;
	public Color colorInicial;
	public Color colorTension;
	public Text contador;

	private int tiempoActual;

	void Start() 
	{
		contador.color = colorInicial;
		tiempoActual = tiempoInicial;
		contador.text = CalcularTiempo (tiempoActual);
		InvokeRepeating ("DecrementarTiempo", 1f, 1f);
	}

	string CalcularTiempo(float tiempo = 0f)
	{
		int horas = 0;
		int minutos = 0;
		int segundos = 0;

		string hora = "";
		string minuto = "";
		string segundo = "";

		if (tiempo < 0) 
		{
			tiempo = 0;
		}

		if (tiempo / 3600 >= 1) {
			horas = (int)tiempo / 3600;
			minutos = (int)(tiempo % 3600) / 60;
			segundos = (int)tiempo % 60;
		}
		else
		{
			horas = 0;
			minutos = (int)tiempo / 60;
			segundos = (int)tiempo % 60;
		}

		if (horas < 10) {
			hora = "0" + horas.ToString ();
		} 
		else 
		{
			hora = horas.ToString ();
		}

		if (minutos < 10) 
		{
			minuto = "0" + minutos.ToString ();
		}
		else 
		{
			minuto = minutos.ToString ();
		}

		if (segundos < 10) 
		{
			segundo = "0" + segundos.ToString();
		}
		else 
		{
			segundo = segundos.ToString ();
		}

		string cadena = hora + ":" + minuto + ":" + segundo;

		return cadena;
	}

	void DecrementarTiempo()
	{
		tiempoActual = tiempoActual - 1;
		contador.text = CalcularTiempo (tiempoActual);

		if (tiempoActual <= tiempoTension)
		{
			contador.color = colorTension;
		}

		if (tiempoActual == 0)
		{
			GameObject[] Puertas = GameObject.Find ("TerminalController").GetComponent<keyCheckerScript>().Puertas;
			for (int i = 0; i < Puertas.Length; i++)
			{
				Puertas [i].GetComponent<Animator> ().enabled = true;
				Puertas [i].GetComponent<BoxCollider2D> ().enabled = false;
			}
			CancelInvoke ();
		}
	}

	void ActualizarTiempo()
	{
		ControlArchivo.ActualizarTiempo ("");
	}
}
