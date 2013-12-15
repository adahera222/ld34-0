using UnityEngine;
using System.Collections;

public class LabelUpdater : MonoBehaviour {

	public string[] arrayOfString;

	int count = 11;
	int currentItem = 0;
	float timeInterval = 10.0f;
	float currentTimeInterval = 0.0f;

	enum State {
		rest = 0,
		action,
	}

	State state = State.rest;

	void Start () {
		arrayOfString = new string[count];
		arrayOfString[0] = "Only one axle for control!";
		arrayOfString[1] = "Only one secret gift on the stage!";
		arrayOfString[2] = "Only one door on the stage!";
		arrayOfString[3] = "Only one key on hte stage!";
		arrayOfString[4] = "Only one stage!";
		arrayOfString[5] = "Only one time I ate cheese soup!";
		arrayOfString[6] = "Only one to complete this game!";
		arrayOfString[7] = "Only one instance of the game can be running at one time! (false)";
		arrayOfString[8] = "Only one hand I used when creating this!";
		arrayOfString[9] = "Only one! Only one! Neo was the chosen one!";
		arrayOfString[10] = "Only one hero you can control here!";
	}

	// void Awake() {
	// 	//
	// }
	
	void Update () {
		if (state == State.rest) {
			//
		}


		// if (currentTimeInterval > timeInterval) {
		// 	currentTimeInterval = 0;
		// } else {
		// 	currentTimeInterval += Time.deltaTime;
		// }

	}
}
