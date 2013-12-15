using UnityEngine;
using System.Collections;

public class FlagTrigger : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.name == "Hero") {
			Destroy(this.gameObject);
			Application.LoadLevel("TheEnd");
		}
	}
}
