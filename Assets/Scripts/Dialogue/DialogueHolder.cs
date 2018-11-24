using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour 
{
	private DialogueManager dManager;
	public string[] dialogueLines;

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
				if (!(dManager.dBoxActive))
				{
					dManager.dialogLines = dialogueLines;
					dManager.currentLine = 0;
					dManager.showDialogue ();
					GameObject.Find ("Player").GetComponent<Movement> ().enabled = false;
					GameObject.Find ("Player").GetComponent<Animator> ().enabled = false;
				}
			}
		}
	}
}