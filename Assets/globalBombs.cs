using UnityEngine;
using System.Collections;

public class globalBombs : MonoBehaviour {

	public static float bombsExploded = 0;

	float takeAway = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (bombsExploded > 0 && takeAway < 1) {
			TimeLeft.timeLeft -= 50;
			takeAway = 1;

		}
	}
}