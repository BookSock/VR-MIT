using UnityEngine;
using System.Collections;
//using UnityEngine.UI;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(Text))]

public class TimeLeft : MonoBehaviour {



	private bool touched = false;
	public static float switchControlls = 0;

	public static bool flagSoundOn = false;

	private TextMesh textField;
	public static float timeLeft = 180.0f;
	string earlyText = "hi";
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
		//Debug.Log (timeLeft);
		earlyText = "Time Left: " + Mathf.Round(timeLeft) + "*" + "Bombs Remaining: " + globalBombs.bombsRemaining;
		earlyText = earlyText.Replace("*", System.Environment.NewLine);
		textField.text = earlyText;
		//Debug.Log("wow this is broken");  confirmed that this runs every loop already
		//Debug.Log(textField.text);
		if(timeLeft < 0)
		{
			SceneManager.LoadScene ("StartMenu");
		}
		//Debug.Log (GvrController.TouchPos);
		if (GvrController.IsTouching == false) {
			touched = false;
		}

		if (GvrController.IsTouching == true) {
			
			if (GvrController.TouchPos.x > 0.7) {
				touched = true;
			}

		}
		if (GvrController.IsTouching == true && touched == true) {
			if (GvrController.TouchPos.x < 0.3) {
				if (switchControlls == 0) {
					switchControlls = 1;
					flagSoundOn = true;
					touched = false;
				} else {
					switchControlls = 0;
					flagSoundOn = true;
					touched = false;
				}
			}

		}
		//Debug.Log (switchControlls);
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
