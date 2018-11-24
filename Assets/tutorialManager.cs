using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialManager : MonoBehaviour {
	public GameObject[] popUps;
	public int popUpIndex;
	void Update()
	{
		for (int i = 0; i < popUps.Length; i++)
		{
			if (i == popUpIndex)
			{
				popUps [i].SetActive (true);
			} 
			else
			{
				popUps [i].SetActive (false);
			}
		}
		if (popUpIndex == 0)
		{
			if (Input.GetKeyDown (KeyCode.LeftArrow))
			{
				
			}
		}
	}
}