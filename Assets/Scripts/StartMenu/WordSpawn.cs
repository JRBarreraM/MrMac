using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawn : MonoBehaviour {

	public GameObject word;
	public GameObject canv;

	void Start () 
	{
		InvokeRepeating ("Inst", 0f, 0.25f);
	}

	void Inst()
	{
		GameObject nextWord = (GameObject)Instantiate(word,canv.transform);
	}
}
