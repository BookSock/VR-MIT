using UnityEngine;
using System.Collections;

public class wtfisgoingon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ParticleSystem pS = GetComponent<ParticleSystem>();
		pS.enableEmission = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
