using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrumpaMovement : MonoBehaviour {

	private Vector3 MovingDirection = Vector3.left;    //initial movement direction
  Animator anim;
	bool isWalkingRight;
	bool isWalkingLeft;

	// Use this for initialization
	void Awake () {
		anim = GetComponent <Animator> ();
	}

	// Update is called once per frame
	void Update () {
			UpdateMovement ();
	}

	void UpdateMovement(){
			if (this.transform.position.x > 2.4f) {
					MovingDirection = Vector3.left;
					isWalkingLeft = true;
					isWalkingRight = false;
					Animating (isWalkingLeft, isWalkingRight);

			} else if (this.transform.position.x < -2f) {
					MovingDirection = Vector3.right;
					isWalkingLeft = false;
					isWalkingRight = true;
					Animating (isWalkingLeft, isWalkingRight);

			}
			this.transform.Translate (MovingDirection * Time.smoothDeltaTime);
	}

	void Animating (bool isWalkingLeft, bool isWalkingRight)	{
		anim.SetBool ("isWalkingLeft", isWalkingLeft);
		anim.SetBool ("isWalkingRight", isWalkingRight);
	}
}
