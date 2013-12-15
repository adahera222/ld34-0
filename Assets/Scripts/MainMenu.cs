using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
		if (Input.GetButton("Jump")) {
			Application.LoadLevel("GameScene");
		}
	}

}
