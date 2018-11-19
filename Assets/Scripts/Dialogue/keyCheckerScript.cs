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
	private GameObject dataController; 

	void Awake()
	{
		dataController = GameObject.Find("DataController"); 
	}

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
				dataController.SendMessage ("ActualizarProgreso");
				//Aqui se manda el mensaje para cambiar de color la pantalla
				input.text = "";
				return;
			}
		}
		Debug.Log ("Incorrecto");
		return;
	}
}