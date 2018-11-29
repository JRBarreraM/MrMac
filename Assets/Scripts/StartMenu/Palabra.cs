using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Palabra : MonoBehaviour {

	private static string rutaBash = Application.dataPath + "/IntroBash/bash.txt";

	public static string SetWord() 
	{
		string[] words = File.ReadAllLines (rutaBash);

		return words[Mathf.RoundToInt (Random.Range (0, words.Length - 1))];
	}
}
