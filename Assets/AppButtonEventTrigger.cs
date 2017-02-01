
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;



public class AppButtonEventTrigger : EventTrigger {

	public void Explode() {
		var exp = GetComponent<ParticleSystem> ();
		exp.Play ();
		Destroy (gameObject, exp.duration);

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



		/*

		if (GvrController.AppButtonDown) {
			Explode ();
		}
		*/
				

			// Do something.
			// AppButtonUp is true for 1 frame after touchpad is touched.
			


	}
	
}



