using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCheckerScript : MonoBehaviour 
{
	public string[] RespuestasRetos;
	public string[] RespuestasBosses;
	public GameObject[] Maquinas;
	public GameObject[] Puertas;
	[SerializeField]
	private InputField input;
	private GameObject dataController;
	public AudioManager aM;

	void Awake()
	{
		dataController = GameObject.Find("DataController");
	}

	public void GetInput(string code)
	{
		for (int i = 0; i < RespuestasRetos.Length; i++)
		{
			if (code.Equals(RespuestasRetos[i]))
			{
				RespuestasRetos [i] = "1er1g16g156eg16vdv1";
				Debug.Log ("Correcto");
				aM.Play ("NormalCorrect");
				dataController.SendMessage ("ActualizarProgreso");
				//Aqui se manda el mensaje para cambiar de color la pantalla
				input.text = "";
				StartCoroutine(ExecuteAfterTime(4));
				return;
			}
		}

		for (int i = 0; i < RespuestasBosses.Length; i++)
		{
			if (code.Equals(RespuestasBosses[i]))
			{
				RespuestasBosses [i] = "1er1g16g156eg16vdv1";
				Debug.Log ("Correcto");
				aM.Play ("NormalCorrect");
				dataController.SendMessage ("ActualizarProgreso");
				//Aqui se manda el mensaje para cambiar de color la pantalla
				input.text = "";
				StartCoroutine(ExecuteAfterTime(10));
				return;
			}
		}
		Debug.Log ("Incorrecto");
		return;
	}
	IEnumerator ExecuteAfterTime(float time)
	{
		yield return new WaitForSeconds (time);
		aM.Stop ("NormalCorrect");
	}
}