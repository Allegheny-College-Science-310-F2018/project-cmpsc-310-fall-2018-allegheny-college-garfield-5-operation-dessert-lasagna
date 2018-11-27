using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementLloyd : MonoBehaviour {

	public float speed;
	bool isMovedLeft = true;
	bool isMovedRight = true;


	// Update is called once per frame
	void Update () {

		speed = 3;

		if (Input.GetKeyDown("a")) // Move left
			{
				isMovedLeft = true;
				isMovedRight = false;
			} else if (Input.GetKeyDown("d")) { // Move right
				isMovedRight = true;
				isMovedLeft = false;
			} else if (Input.GetKeyUp("a") && Input.GetKeyUp("b")) { // Doesn't move
				isMovedLeft = false;
				isMovedRight = false;
			}

		if (isMovedRight)
			{
				transform.Translate(Vector3.right * Time.deltaTime * speed);
		} else if (isMovedLeft) {
				transform.Translate(Vector3.left * Time.deltaTime * speed);
		}
	}
}
