using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementArmin : MonoBehaviour {

	public float speed;
	bool isMovedLeft = true;
	bool isMovedRight = true;
	public Vector2 jumpHeight;

	// Update is called once per frame
	void Update () {

		speed = 3;

		if (Input.GetKeyDown(KeyCode.LeftArrow)) // Move left
			{
				isMovedLeft = true;
				isMovedRight = false;
			} else if (Input.GetKeyDown(KeyCode.RightArrow)) { // Move right
				isMovedRight = true;
				isMovedLeft = false;
			} else { // Doesn't move
				isMovedLeft = false;
				isMovedRight = false;
			}

		if (isMovedRight)
			{
				transform.Translate(Vector3.right * Time.deltaTime * speed);
		} else if (isMovedLeft) {
				transform.Translate(Vector3.left * Time.deltaTime * speed);
		}

    if (Input.GetKeyDown(KeyCode.UpArrow))  //jump
    {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0,10), ForceMode2D.Impulse);
		}
}
