using UnityEngine;
using System.Collections;

public class SwitchSoundScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (TimeLeft.flagSoundOn == true) {
			AudioSource source = gameObject.GetComponent<AudioSource> ();
			source.Play ();
			TimeLeft.flagSoundOn = false;
		}
	}
}
