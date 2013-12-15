using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.name == "Hero") {
			if (GameObject.Find("Hero").GetComponent<HeroStates>().isKeyCollected) {
				Destroy(this.gameObject);
			}	
		}
	}

}
