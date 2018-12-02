using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public GameObject dataController;
	public GameObject anim;
	public GameObject mac;
	public GameObject start;
	public GameObject sure;
	public GameObject name;
	public GameObject messageBox;
	public GameObject inputField;
	public GameObject fondo;
	public Text field;
	public Text holder;
	public InputField input;
//	public AudioManager aM;

	private int cont = 0;

	void Awake () {
		mac.SetActive (true);
		start.SetActive (true);
		fondo.SetActive (true);
		messageBox.SetActive (false);
		inputField.SetActive (false);
		name.SetActive (false);
		sure.SetActive (false);
	}

	void Start()
	{
		FindObjectOfType<AudioManager> ().Play ("Intro");
	}
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			cont = 1;
		}

		if (cont == 1)
		{
			anim.SendMessage ("StopAnimation");
			mac.SetActive (false);
			start.SetActive (false);
			fondo.SetActive (false);
			name.SetActive (true);
			inputField.SetActive (true);
			cont = 2;
		}

		if (cont == 2) {
			if (Input.GetKeyDown (KeyCode.Return) && !field.text.Equals (string.Empty)) 
			{
				name.SetActive (false);
				sure.SetActive (true);
				messageBox.SetActive (true);
				cont = 3;
			}
		}
	
		if (cont == 3) 
		{
			if (Input.GetKeyDown (KeyCode.Y)) 
			{
				string groupName = field.text;
				ControlArchivo.ActualizarGrupo (groupName);
				FindObjectOfType<AudioManager> ().Stop ("Intro");
				SceneManager.LoadScene ("metaFUME");
			}

			if (Input.GetKeyDown (KeyCode.N)) 
			{
				name.SetActive (true);
				sure.SetActive (false);
				messageBox.SetActive (false);
				cont = 2;
				input.text = string.Empty;
			}
		}
	}
}
