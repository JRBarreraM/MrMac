using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour 
{
	public GameObject dBox;
	public GameObject tBox;
	public Text dText;
	public bool dBoxActive;
	public bool tBoxActive;

	// Use this for initialization
	void Start () 
	{
		dBoxActive = true;
		tBoxActive = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (dBoxActive &&  tBoxActive && Input.GetKeyDown (KeyCode.Return))
		{
			dBox.SetActive (false);
			tBox.SetActive (false);
			dBoxActive = false;
			tBoxActive = false;
			GameObject.Find ("Player").GetComponent<Animator> ().enabled = true;
			GameObject.Find ("Player").GetComponent<Movement> ().enabled = true;
		}
	}

	public void showBox(string dialogue)
	{
		dBox.SetActive (true);
		tBox.SetActive (true);
		dBoxActive = true;
		tBoxActive = true;
		dText.text = dialogue;
	}
}