using UnityEngine;
using System.Collections;

public class KeyTriger : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		Destroy(this.gameObject);
	}
}
