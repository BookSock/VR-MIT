using UnityEngine;
using System.Collections;

public class Peek : MonoBehaviour {


	float numPeeks = 0;
	float timePeeking = 0;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timePeeking > 0) {
			timePeeking -= 1;
		}
		if (timePeeking == 0 && gameObject.GetComponent<Renderer>().enabled == false) {
			gameObject.GetComponent<Renderer>().enabled = true;
		}

		if (GvrController.AppButton && numPeeks < 2 && timePeeking < 1) {
			numPeeks += 1;
			timePeeking += 200;
			gameObject.GetComponent<Renderer>().enabled = false;
	
		}
	}
}
