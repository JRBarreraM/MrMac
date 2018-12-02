using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class InvokeScene : MonoBehaviour
{
	void Start ()
	{
		Invoke ("transition",3f);
	}

	void transition()
	{
		SceneManager.LoadScene ("Start");
	}
}