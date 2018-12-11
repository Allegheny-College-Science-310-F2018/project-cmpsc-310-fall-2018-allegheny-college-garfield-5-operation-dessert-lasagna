using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrumpaMovement : MonoBehaviour {

	public float speed;
	bool isMovedLeft = true;
	bool isMovedRight = false;

	void Awake () {
	}
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (isMovedLeft = true) {
			isMovedLeft = false;
			isMovedRight = true; 
		}
	}
}
