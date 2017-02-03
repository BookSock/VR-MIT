using UnityEngine;
using System.Collections;

public class playIjntroAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AudioSource source = gameObject.GetComponent<AudioSource> ();
		source.Play ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
