using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawn : MonoBehaviour {

	public GameObject word;
	public GameObject canv;
	public float wordTime = 0.5f;

	void Start () 
	{
		InvokeRepeating ("Inst", wordTime, wordTime);
	}

	void Inst()
	{
		GameObject nextWord1 = (GameObject)Instantiate(word);
		nextWord1.transform.SetParent (canv.transform,true);
	}

	public void StopAnimation()
	{
		CancelInvoke ();
	}
}
