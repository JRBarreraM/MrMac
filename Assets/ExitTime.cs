using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTime : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			Debug.Log ("Salir");
			Application.Quit ();
		}
	}
}
