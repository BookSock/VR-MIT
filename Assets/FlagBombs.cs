using UnityEngine;
using System.Collections;

public class FlagBombs : MonoBehaviour {

	public Material flaggedMaterial;
	public Material regMaterial;

	public static bool playFlagSound = false;

	bool materialFlagged = false;

	public void flagTheBomb () {
		if (TimeLeft.switchControlls == 1) {
			//flag bombs

			if (materialFlagged == false) {
				Debug.Log("regmaterial then changed");
				materialFlagged = true;
				gameObject.GetComponent<Renderer> ().material = flaggedMaterial;
				playFlagSound = true;
			} else {
				Debug.Log("flaggedmaterial then changed");
				gameObject.GetComponent<Renderer> ().material = regMaterial;
				materialFlagged = false;
				playFlagSound = true;
			}
		}
	}
	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

		//gameObject.GetComponent<Material> ().
		//if gameObject.GetComponent.




	
	}

	//now make different even trigger scripts and enable or disable them based on the switchcontrolls thing
}
