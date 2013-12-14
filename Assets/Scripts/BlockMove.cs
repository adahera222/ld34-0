using UnityEngine;
using System.Collections;

public class BlockMove : MonoBehaviour {

	public float lowY = 0;
	public float highY = 10;

	enum Direction {
		up = 1,
		down = -1,
	}

	float movementSpeed = 5.0f;

	Direction currentDirection = Direction.up;

	void Start () {
		//
	}
	
	void Update () {
		float currectPosition = this.transform.position.y;
		if (currectPosition >= highY) {
			currentDirection = Direction.down;
		}
		if (currectPosition <= lowY) {
			currentDirection = Direction.up;
		}

		int dir = 0;
		switch (currentDirection) {
			case Direction.down:
				dir = -1;
				break;
			case Direction.up:
				dir = 1;
				break;
		}

		this.rigidbody2D.velocity = new Vector3(0, movementSpeed * dir, 0);
	}

}
