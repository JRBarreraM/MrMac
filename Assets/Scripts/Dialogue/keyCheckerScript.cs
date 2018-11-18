using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCheckerScript : MonoBehaviour 
{
	public string[] RespuestasRetos;
	public string[] RespuestasBosses;
	[SerializeField]
	private InputField input;
	public void GetInput(string code)
	{
		if (code.Equals ("shame"))
		{
			//no estoy claro
		}
		for (int i = 0; i < RespuestasRetos.Length; i++)
		{
			if (code.Equals(RespuestasRetos[i]))
			{
				RespuestasRetos [i] = "";
				Debug.Log ("Correcto");
				FindObjectOfType<AudioManager>().Play ("NormalCorrect");
				//Aqui Carlos Aumenta la Barra de hackeo
				//Aqui se manda el mensaje para cambiar de color la pantalla
				input.text = "";
				return;
			}
		}
		Debug.Log ("Incorrecto");
		return;
	}
}