using UnityEngine;
using System.Collections;
//using UnityEngine.UI;


//[RequireComponent(typeof(Text))]

public class TimeLeft : MonoBehaviour {




	private TextMesh textField;
	public static float timeLeft = 300.0f;

	// Use this for initialization

	void Awake() {
		//textField = GetComponent<Text>();
	}


	void Start () {
		//textField = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		textField = GetComponent<TextMesh>();
		timeLeft -= Time.deltaTime;
		textField.text = "Time Left:" + Mathf.Round(timeLeft);
		//Debug.Log("wow this is broken");  confirmed that this runs every loop already
		//Debug.Log(textField.text);
		if(timeLeft < 0)
		{
			//Application.LoadLevel("gameOver");
		}
	}

	void LateUpdate() {
		/*
    float deltaTime = Time.unscaledDeltaTime;
    float interp = deltaTime / (0.5f + deltaTime);
    float currentFPS = 1.0f / deltaTime;
    fps = Mathf.Lerp(fps, currentFPS, interp);
    float msf = MS_PER_SEC / fps;

		textField = GetComponent<Text>();
		timeLeft -= Time.deltaTime;
		textField.text = "Time Left:" + Mathf.Round(timeLeft);
		if(timeLeft < 0)
		{
			//Application.LoadLevel("gameOver");
		}
		*/
	}


}
