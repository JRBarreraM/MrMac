using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class tutorialManager : MonoBehaviour {
	public GameObject player;
	public GameObject[] popUps;
	public string[] RespuestasRetosMaricos;
	private int popUpIndex=0;
	private bool todosIguales=true;

	void monteFuma()
	{
		SceneManager.LoadScene ("MainScene");
	}

	void Update ()
	{
		RespuestasRetosMaricos = GameObject.Find ("TerminalController").GetComponent<keyCheckerScript> ().RespuestasRetosMaricos;
		for (int i = 0; i < RespuestasRetosMaricos.Length; i++)
		{
			if (!(RespuestasRetosMaricos [i].Equals ("1er1g16g156eg16vdv1")))
			{
				todosIguales = false;
				break;
			}
			todosIguales = true;
		}

		if (todosIguales)
		{
			popUpIndex = 4;
		}

		if (popUpIndex == 0) {
			popUps [popUpIndex].SetActive (true);
			if ((Input.GetKeyDown (KeyCode.LeftArrow)) ||
			    (Input.GetKeyDown (KeyCode.RightArrow)) ||
			    (Input.GetKeyDown (KeyCode.UpArrow)) ||
			    (Input.GetKeyDown (KeyCode.UpArrow)) ||
			    (Input.GetKeyDown (KeyCode.DownArrow)) ||
			    (Input.GetKeyDown (KeyCode.D)) ||
			    (Input.GetKeyDown (KeyCode.S)) ||
			    (Input.GetKeyDown (KeyCode.A)) ||
			    (Input.GetKeyDown (KeyCode.W))) {
				popUps [popUpIndex].SetActive (false);
				popUpIndex++;
			}
		} else if (popUpIndex == 1) {
			popUps [popUpIndex].SetActive (true);
			GameObject.Find ("Player").GetComponent<Movement> ().enabled = false;
			GameObject.Find ("Player").GetComponent<Animator> ().enabled = false;
			if (Input.GetKeyDown (KeyCode.Return)) {
				popUps [popUpIndex].SetActive (false);
				GameObject.Find ("Player").GetComponent<Movement> ().enabled = true;
				GameObject.Find ("Player").GetComponent<Animator> ().enabled = true;
				popUpIndex++;
				return;
			}
		} else if (popUpIndex == 4)
		{
			popUps [popUpIndex-2].SetActive (true);
			if (Input.GetKeyDown (KeyCode.Return)) {
				popUps [popUpIndex-2].SetActive (false);
				Invoke ("monteFuma",3f);
				return;
			}			
		}
	}
}