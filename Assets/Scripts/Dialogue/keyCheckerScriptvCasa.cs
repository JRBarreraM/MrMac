using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class keyCheckerScriptvCasa : MonoBehaviour
{
	public string[] RespuestasRetos;
	[SerializeField]
	private InputField input;
	private GameObject dataController;

	void Awake()
	{
		dataController = GameObject.Find("DataController");
	}

	public void GetInput(string code)
	{

		for (int i = 0; i < RespuestasRetos.Length; i++)
		{
			if (code.Equals (RespuestasRetos [i]))
			{
				RespuestasRetos [i] = "1er1g16g156eg16vdv1";
				Debug.Log ("Correcto");
				//Aqui se manda el mensaje para cambiar de color la pantalla
				input.text = "";
				return;
			}
		}
		Debug.Log ("Incorrecto");
		return;
	}
}