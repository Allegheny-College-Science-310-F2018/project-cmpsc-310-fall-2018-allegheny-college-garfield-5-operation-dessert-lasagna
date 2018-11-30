using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementLloyd : MonoBehaviour {

	public float speed;
	bool isMovedLeft = true;
	bool isMovedRight = true;
	public Vector2 jumpHeight;
	bool isInAir = false;

	// Update is called once per frame
	void Update () {

		speed = 5;

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

		if (Input.GetKeyDown("w") && isInAir == false)  //jump
		{
			isInAir = true;
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0,10), ForceMode2D.Impulse);
		}
	}

	// called when the character hits a thing
	void OnCollisionEnter2D(Collision2D col)
	{
		isInAir = false;
	}
}
