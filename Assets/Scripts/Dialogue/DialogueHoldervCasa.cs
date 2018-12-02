using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueHoldervCasa : MonoBehaviour
{
	private DialogueManager dManager;
	public string[] dialogueLines;
	public string answer;
	public bool suma;
	public bool PC;
	public AudioManager aM;
	public string name;
	private bool contact = false;
	private bool habilitado = true;
	public GameObject dataController;
	[SerializeField]
	public InputField input;
		
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

	// Update is called once per frame
	void Update ()
	{
		if (contact && Input.GetKeyDown (KeyCode.Return) && habilitado)
		{
//			dManager.SendMessage ("showDialogue", actualDialogue);
			dManager.dialogLines = dialogueLines;
			GameObject.Find ("Player").GetComponent<Movement> ().enabled = false;
			GameObject.Find ("Player").GetComponent<Animator> ().enabled = false;
		}
	}

	public void GetInput(string code)
	{
		if (code.Equals (answer))
		{
			habilitado = false;
			answer = "1er1g16g156eg16vdv1";
			Debug.Log ("Correcto");
			aM.Play ("NormalCorrect");
			if (suma)
			{
				dataController.SendMessage ("ActualizarProgreso");
			}
			if (!(suma))
			{
				GetComponent<Animator> ().enabled = true;
			}
			if (!(PC))
			{
				GetComponent<BoxCollider2D> ().enabled = false;

				StartCoroutine(ExecuteAfterTime(10));
			}
			if (PC)
			{
				StartCoroutine(ExecuteAfterTime(4));
			}
			input.text = "";
			return;
		}
		Debug.Log ("Incorrecto");
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