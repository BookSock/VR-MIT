using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class globalBombs : MonoBehaviour {

	public static float bombsExploded = 0;
	public static float bombsRemaining = 3;

	float takeAway = 0;

	/*
	IEnumerator Example () {
		yield return new WaitForSeconds(6000.0f);
	}
	*/

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bombsRemaining = 3 - bombsExploded;
		if (bombsExploded > 1 && takeAway < 1) { //change this later
			//TimeLeft.timeLeft -= 50f;
			Debug.Log("is it working");

			//yield return new WaitForSeconds(4.0f);
			SceneManager.LoadScene("StartMenu");
			takeAway = 1;

		}
	}// delays before sounds
}