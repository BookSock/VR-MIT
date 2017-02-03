using UnityEngine;
using System.Collections;

public class RandomizeCubes : MonoBehaviour {

	void Shuffle<T> (this System.Random rng, T[] array)
	{
		int n = array.Length;
		while (n > 1) 
		{
			int k = rng.Next(n--);
			T temp = array[n];
			array[n] = array[k];
			array[k] = temp;
		}
	}


	// Use this for initialization
	void Start () {

		System.Random rng = new System.Random();

		Vector3[] positionArray = new Vector3[7];
		positionArray[0] = new Vector3(-13,1,-4);            
		positionArray[1] = new Vector3(-9,1,-4);
		positionArray[2] = new Vector3(-23,1,-2);
		positionArray[3] = new Vector3(-35,1,4);
		positionArray[4] = new Vector3(30,1,0);
		positionArray[5] = new Vector3(4,1,-38);
		positionArray[6] = new Vector3(-1,1,-34);
		//positionArray[3] = new Vector3(0.5f,0.5f,0.5f);

		//Transform.position = positionArray[0]; should be the type of code but can i reference outside objects or no?

		Shuffle (rng, positionArray);
		Debug.Log (positionArray [0]);
		GameObject bomb4 = GameObject.Find("CubeBomb");
		bomb4.transform.position = positionArray[0];
		GameObject not2 = GameObject.Find("CubeBomb (1)");
		not2.transform.position = positionArray[1];
		GameObject not3 = GameObject.Find("CubeBomb (5)");
		not3.transform.position = positionArray[2];
		GameObject not4 = GameObject.Find("CubeNot");
		not4.transform.position = positionArray[3];
		GameObject not5 = GameObject.Find("CubeNot (5)");
		not5.transform.position = positionArray[4];
		GameObject not6 = GameObject.Find("CubeNot (6)");
		not6.transform.position = positionArray[5];
		GameObject not7 = GameObject.Find("CubeNot (7)");
		not7.transform.position = positionArray[6];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
