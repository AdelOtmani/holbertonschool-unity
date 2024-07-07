using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public int PlayerSpeed = 10;
	public bool FacingRight = true;
	public int JumpPower= 1250;
	public float moveX;
	public bool OnGround;

	// Update is called once per frame
	void Update () {
		PlayerMove ();
		PlayerRaycast ();
	}

	void PlayerMove() {
		//CONTROLS
		moveX = Input.GetAxis("Horizontal");
		if (Input.GetButtonUp ("Jump") && OnGround == true){
			Jump();
		}
		//ANIMATIONS
		//PLAYER DIRECTION
		if (moveX < 0.0f && FacingRight == false){
			FlipPlayer();
		}
		else if (moveX > 0.0f && FacingRight == true) {
			FlipPlayer();
		}
		//PHYSICS
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * PlayerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}

	void Jump() {
		//JUMPING CODE
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * JumpPower);
		OnGround = false;
	}

	void FlipPlayer() {
		FacingRight = !FacingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		//if (FacingRight == false){
			//localScale.x =2;
		//}
		transform.localScale = localScale;
	}
	void OnCollisionEnter2D (Collision2D col) {
		//Debug.Log ("Player collided with " + col.collider.name);
		//if (col.gameObject.tag == "Ground") {
			//OnGround = true;
		//}
	}

	void PlayerRaycast () {
		//Ray Up
		RaycastHit2D rayUp = Physics2D.Raycast (transform.position, Vector2.up);
		if (rayUp != null && rayUp.collider != null && rayUp.distance < 0.9f && rayUp.collider.tag == "box"){
			Destroy (rayUp.collider.gameObject);
		}

		//Ray Down
		RaycastHit2D rayDown = Physics2D.Raycast (transform.position, Vector2.down);
		if (rayDown != null && rayDown.collider != null && rayDown.distance < 0.9f && rayDown.collider.tag == "enemy"){
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 100);
			rayDown.collider.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up *100);
			rayDown.collider.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.right *200);
			rayDown.collider.gameObject.GetComponent<Rigidbody2D> ().freezeRotation = false;
			rayDown.collider.gameObject.GetComponent<BoxCollider2D> ().enabled = false;
			rayDown.collider.gameObject.GetComponent<EnemyMove> ().enabled = false;

		}
		if (rayDown != null && rayDown.collider != null && rayDown.distance < 0.9f && rayDown.collider.tag != "enemy"){
			OnGround = true;
		}
	}
}
