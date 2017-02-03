using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void StartGame() {
		SceneManager.LoadScene ("MineGamescene1");
	}
	
	// Update is called once per frame
	void Update () {
		if (GvrController.AppButton == true) {
			SceneManager.LoadScene ("MineGamescene1");
		}
	}
}