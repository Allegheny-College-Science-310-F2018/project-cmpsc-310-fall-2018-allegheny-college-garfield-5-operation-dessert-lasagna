using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementArmin : MonoBehaviour {

	public float speed;
	bool isMovedLeft = false;
	bool isMovedRight = false;
	public Vector2 jumpHeight;
	bool isInAir = false;
	Animator anim;
	AudioSource jumpAudio;
	bool isPunchingRight;
	bool isPunchingLeft;
	bool hasPunched;
	private int wait;
	public float punchWait = 1.0f;
	float timer;


	void Awake () {
		anim = GetComponent <Animator> ();
		jumpAudio = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

		speed = 3.0f;

		checkPunch ();

		if (Input.GetKey(KeyCode.LeftArrow) && isInAir == true) // Move left
			{
				isMovedLeft = true;
				isMovedRight = false;
				Animating (isMovedLeft, isMovedRight);
			} else if (Input.GetKey(KeyCode.RightArrow) && isInAir == true) { // Move right
				isMovedRight = true;
				isMovedLeft = false;
				Animating (isMovedLeft, isMovedRight);
			} else { // Doesn't move
				isMovedLeft = false;
				isMovedRight = false;
				Animating (isMovedLeft, isMovedRight);
			}

		if (isMovedRight)
			{
				transform.Translate(Vector3.right * Time.deltaTime * speed);
		} else if (isMovedLeft) {
				transform.Translate(Vector3.left * Time.deltaTime * speed);
		}

    if (Input.GetKeyDown(KeyCode.UpArrow) && isInAir == false)  //jump
    {
			isInAir = true;
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0,10), ForceMode2D.Impulse);
			jumpAudio.Play ();
		}

		if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow) && hasPunched == false) {
			isPunchingRight = true;
			hasPunched = true;
			AnimatingPunch (isPunchingRight, isPunchingLeft);
		}	else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow) && hasPunched == false) {
			isPunchingLeft = true;
			hasPunched = true;
			AnimatingPunch (isPunchingRight, isPunchingLeft);
		}
	}

	// called when the character hits a thing
  void OnCollisionEnter2D (Collision2D col)
  {
		isInAir = false;
  }

	void Animating (bool isMovedLeft, bool isMovedRight)	{
		anim.SetBool ("isMovedLeft", isMovedLeft);
		anim.SetBool ("isMovedRight", isMovedRight);
	}

	void AnimatingPunch (bool isPunchingRight, bool isPunchingLeft) {
		anim.SetBool ("isPunchingRight", isPunchingRight);
		anim.SetBool ("isPunchingLeft", isPunchingLeft);
	}

	void checkPunch () {
		timer += Time.deltaTime;
		if (timer >= punchWait) {
			isPunchingLeft = false;
			isPunchingRight = false;
			AnimatingPunch (isPunchingRight, isPunchingLeft);
			hasPunched = false;
			timer = 0f;
		}
	}
}
