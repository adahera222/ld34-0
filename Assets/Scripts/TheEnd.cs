using UnityEngine;
using System.Collections;

public class TheEnd : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
		if (Input.GetButton("Jump")) {
			Application.LoadLevel("MainMenu");
		}
	}

}
