using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordBehavior : MonoBehaviour {

	public float minScale = 5f;
	public float maxScale = 20f;
	public float padding = 100f;

	void Start () {
		Vector3 ranPos = new Vector3(Random.Range(0f + padding,Screen.width - padding),
									 Random.Range(0f + padding,Screen.height - padding),0f);
		transform.position = ranPos;

		Text txt = GetComponent <Text>();
		txt.fontSize = Mathf.RoundToInt(Random.Range (minScale, maxScale));
		txt.text = Palabra.SetWord ();
	}
}
