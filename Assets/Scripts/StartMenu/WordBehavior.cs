using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordBehavior : MonoBehaviour {

	public float offset = 5f;
	public float maxHeight = 5f;
	public float maxWidth = 8.65f; 

	void Start () {

		Vector3 ranPos = new Vector3(Random.Range(-(maxWidth - offset),maxWidth - offset),Random.Range(-(maxHeight - offset),maxHeight - offset),0f);
		transform.position = ranPos;
	}

	void Update () {
		
	}
}
