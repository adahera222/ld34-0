using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public enum ControllerState {
		Rest = 0,
		Left,
		Right,
	};

	ControllerState state = ControllerState.Rest;
	ControllerState lastState = 0;

	public float walkingSpeed = 25.0f;

	void Start () {
		//
	}
	
	void Update () {
		//
	}

	void FixedUpdate() {
        int horizontal = (int) Input.GetAxis("Horizontal");

        // lastState = 0;

        // switch (horizontal) {
        // 	case 1:
        // 		state = ControllerState.Right;
        // 		Debug.Log("right");
        // 		break;

        // 	case -1:
        // 		state = ControllerState.Left;
        // 		Debug.Log("left");
        // 		break;

        // 	default:
        // 		break;
        // }

        // lastState = state;

        Vector3 currentSpeed = this.rigidbody2D.velocity;
        this.rigidbody2D.velocity = new Vector3(horizontal * walkingSpeed, currentSpeed.y, 0);
	}
}
