using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour 
{
	private DialogueManager dManager;
	public string[] dialogueLines;
	public string[] dialogueLinesAlter;
	private string[] RespuestasRetos;
	public string caller;
	private bool alter=false;
	private bool contact = false;
	private int hablar = 0;


	// Use this for initialization
	void Start () 
	{
		dManager = FindObjectOfType<DialogueManager> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name.Equals("Player"))
		{
			contact = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.name.Equals("Player"))
		{
			contact = false;
		}
	}

	void Update()
	{
		if (Input.GetKeyUp (KeyCode.Return) && contact)
		{
			if (hablar<dialogueLines.Length) {
				hablar++;
				if (caller.Equals ("FinalPC")) {

					RespuestasRetos = GameObject.Find ("TerminalController").GetComponent<keyCheckerScript> ().RespuestasRetos;
					GameObject.Find ("TerminalController").GetComponent<keyCheckerScript> ().aM.Stop ("NormalCorrect");
					for (int i = 0; i < RespuestasRetos.Length; i++) {
						if (!(RespuestasRetos [i].Equals ("1er1g16g156eg16vdv1"))) {
							alter = true;
						}
					}
				}
				if (!(dManager.dBoxActive)) {
					if (alter) {
						dManager.dialogLines = dialogueLinesAlter;
					} else {
						dManager.dialogLines = dialogueLines;
					}
					dManager.showDialogue ();
					GameObject.Find ("Player").GetComponent<Movement> ().enabled = false;
					GameObject.Find ("Player").GetComponent<Animator> ().enabled = false;
				}
			}
			else
			{
				hablar = 0;
			}
		}
	}
}