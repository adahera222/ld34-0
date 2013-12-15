using UnityEngine;
using System.Collections;

public class KeyTriger : MonoBehaviour {

	public AudioClip keySound;

	void Start () {
		
	}
	
	void Update () {
		//
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.name == "Hero") {
			// audio.PlayOneShot(keySound);
			Destroy(this.gameObject);
			GameObject.Find("Hero").GetComponent<HeroStates>().isKeyCollected = true;
		}
	}

}
