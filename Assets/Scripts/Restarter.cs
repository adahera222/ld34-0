using UnityEngine;
using System.Collections;

public class Restarter : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
		if (Input.GetButton("r")) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
