using UnityEngine;
using System.Collections;

public class playFlag : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (FlagBombs.playFlagSound == true) {
			AudioSource source = gameObject.GetComponent<AudioSource> ();
			source.Play ();
			FlagBombs.playFlagSound = false;
		}
	
	}
}
