using UnityEngine;
using System.Collections;

public class explode : MonoBehaviour {

	public void Explode() {
		if (gameObject.GetComponent<Renderer> ().enabled == true) {
			var exp = GetComponent<ParticleSystem> ();
			exp.Play ();
			gameObject.GetComponent<Renderer> ().enabled = false;
			globalBombs.bombsExploded += 1;
			Destroy (gameObject, exp.duration);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		
	}
}
