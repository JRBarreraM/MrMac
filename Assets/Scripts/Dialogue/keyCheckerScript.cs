using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class keyCheckerScript : MonoBehaviour 
{
	public string[] RespuestasRetos;
	public string[] RespuestasBosses;
	public string[] RespuestasRetosMaricos;
	public GameObject[] Maquinas;
	public GameObject[] Puertas;
	[SerializeField]
	private InputField input;
	private GameObject dataController;
	public AudioManager aM;

	void Awake()
	{
		dataController = GameObject.Find("DataController");
//		aM.Stop ("NormalCorrect");
	}

	public void GetInput(string code)
	{

		for (int i = 0; i < RespuestasRetos.Length; i++) {
			if (code.Equals (RespuestasRetos [i])) {
				RespuestasRetos [i] = "1er1g16g156eg16vdv1";
				Debug.Log ("Correcto");
				aM.Play ("NormalCorrect");
				dataController.SendMessage ("ActualizarProgreso");
				Maquinas [i].transform.GetChild (0).gameObject.SetActive (false);
				Maquinas [i].GetComponent<Animator> ().enabled = true;
				input.text = "";
				StartCoroutine (ExecuteAfterTime (4));
				return;
			}
		}

		for (int i = 0; i < RespuestasBosses.Length; i++) {
			if (code.Equals (RespuestasBosses [i])) {
				RespuestasBosses [i] = "1er1g16g156eg16vdv1";
				Debug.Log ("Correcto");
				aM.Play ("NormalCorrect");
				dataController.SendMessage ("ActualizarProgreso");
				Puertas [i].GetComponent<Animator> ().enabled = true;
				Puertas [i].GetComponent<BoxCollider2D> ().enabled = false;
				Puertas [i].transform.GetChild (0).gameObject.SetActive (false);
				input.text = "";
				if (!(code.Equals ("3xploit"))) {
					StartCoroutine (ExecuteAfterTime (10));
				}
				return;
			}
		}

		for (int i = 0; i < RespuestasRetosMaricos.Length; i++) {
			if (code.Equals (RespuestasRetosMaricos [i])) {
				RespuestasRetosMaricos [i] = "1er1g16g156eg16vdv1";
				aM.Play ("NormalCorrect");
				Debug.Log ("Correcto");
				input.text = "";
				return;
			}
		}

		if (code.Equals("wh1ter0se"))
		{
			SceneManager.LoadScene("Start");
		}
		Debug.Log ("Incorrecto");
		aM.Play ("InCorrect");
		input.text = "";
		return;
	}

	IEnumerator ExecuteAfterTime(float time)
	{
		Debug.Log ("Pausa");
		yield return new WaitForSeconds (time);
		Debug.Log ("Wait");
		aM.Pause ("NormalCorrect");
	}
}