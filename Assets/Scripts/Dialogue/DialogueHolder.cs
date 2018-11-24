﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour 
{
	public string dialogue;
	private DialogueManager dManager;

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
				dManager.showBox(dialogue);
				GameObject.Find ("Player").GetComponent<Movement> ().enabled = false;
				GameObject.Find ("Player").GetComponent<Animator> ().enabled = false;
			}
		}
	}
}