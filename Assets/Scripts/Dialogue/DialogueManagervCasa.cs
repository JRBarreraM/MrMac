using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManagervCasa : MonoBehaviour 
{
	public GameObject dBox;
	public GameObject tBox;
	public Text dText;
	public bool dBoxActive;
	public bool tBoxActive;
	private string[] dialogLines;
	private int currentLine;
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
			currentLine++;
		}

		if (currentLine >= dialogLines.Length)
		{
			dBox.SetActive (false);
			tBox.SetActive (false);
			dBoxActive = false;
			tBoxActive = false;
			GameObject.Find ("Player").GetComponent<Animator> ().enabled = true;
			GameObject.Find ("Player").GetComponent<Movement> ().enabled = true;
			currentLine = 0;

		}
		if (currentLine < dialogLines.Length) {
			dText.text = dialogLines [currentLine];
		}
	}

	public void showDialogue(string[] linesToShow)
	{
		dBox.SetActive (true);
		tBox.SetActive (true);
		dBoxActive = true;
		tBoxActive = true;
		currentLine = 0;
		dialogLines = linesToShow;
	}
}