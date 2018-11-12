using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador : MonoBehaviour 
{
	[Header("Referencia al controlador de juego")]
	public GameObject controlador;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			controlador.SendMessage ("ActualizarProgreso");
		}
	}

	void OnTriggerEnter2D(Collider2D otro)
	{
		if (otro.gameObject.tag == "Nivel")
		{
			controlador.SendMessage ("ActualizarProgreso");
			Destroy (otro.gameObject);
		}
	}

}
