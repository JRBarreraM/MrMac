using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCheckerScript : MonoBehaviour 
{
	public string[] Respuestas;
	[SerializeField]
	private InputField input;
	public void GetInput(string code)
	{
		if (code.Equals ("shame"))
		{
			//no estoy claro
		}
		for (int i = 0; i < Respuestas.Length; i++)
		{
			if (code.Equals(Respuestas[i]))
			{
				Respuestas [i] = "";
				Debug.Log ("Correcto");
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