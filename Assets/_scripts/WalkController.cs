using UnityEngine;
using System.Collections;

public class WalkController : MonoBehaviour {

	public float maxSpeed = 3;
	private bool facingRight = true;
	public float velocity = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		velocity = move * maxSpeed;

		if (velocity > 0 && !facingRight) {
			Flip ();
		} else if (velocity < 0 && facingRight) {
			Flip ();
		}
	}

	void Flip () {
		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
