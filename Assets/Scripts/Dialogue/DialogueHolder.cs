using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour 
{
	private DialogueManager dManager;
	public string[] dialogueLines;
	public string caller;
	// Use this for initialization
	void Start () 
	{
		dManager = FindObjectOfType<DialogueManager> ();
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.name.Equals("Player"))
		{
			if (Input.GetKeyUp(KeyCode.Return))
			{
				if (caller.Equals ("FinalPC"))
				{
					GameObject.Find("TerminalController").GetComponent<keyCheckerScript>().aM.Stop("NormalCorrect");
				}
				if (!(dManager.dBoxActive))
				{
					dManager.dialogLines = dialogueLines;
					dManager.showDialogue ();
					GameObject.Find ("Player").GetComponent<Movement> ().enabled = false;
					GameObject.Find ("Player").GetComponent<Animator> ().enabled = false;
				}
			}
		}
	}
}