using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialManager : MonoBehaviour {
	public GameObject[] popUps;
	private int popUpIndex=0;
	
	void Update ()
	{
		if (popUpIndex == 0) 
		{
			popUps [popUpIndex].SetActive (true);
			if ((Input.GetKeyDown (KeyCode.LeftArrow)) ||
			    (Input.GetKeyDown (KeyCode.RightArrow)) ||
			    (Input.GetKeyDown (KeyCode.UpArrow)) ||
				(Input.GetKeyDown (KeyCode.UpArrow)) ||
				(Input.GetKeyDown (KeyCode.DownArrow)) ||
				(Input.GetKeyDown (KeyCode.D)) ||
				(Input.GetKeyDown (KeyCode.S)) ||
				(Input.GetKeyDown (KeyCode.A)) ||
				(Input.GetKeyDown (KeyCode.W)))
			{
				popUps [popUpIndex].SetActive (false);
				popUpIndex++;
			}
		}
		else if(popUpIndex == 1)
		{
			popUps [popUpIndex].SetActive (true);
			if (Input.GetKeyDown (KeyCode.Return))
			{
				popUps [popUpIndex].SetActive (false);
				popUpIndex++;
				return;
			}
		}

	}
}