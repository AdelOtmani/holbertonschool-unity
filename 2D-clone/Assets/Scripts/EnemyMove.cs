using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	public int EnemySpeed;
	public int XMoveDirection;
	public bool FacingRight = true;

	// Update is called once per frame
	void Update () {
		RaycastHit2D hit = Physics2D.Raycast (transform.position, new Vector2 (XMoveDirection, 0));
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (XMoveDirection, 0) * EnemySpeed;
		if (hit.distance < 0.3f){
			FlipEnemy ();
			if (hit.collider.tag == "Player"){
				Destroy (hit.collider.gameObject);
			}
		}
	}

	void FlipEnemy () {
		FacingRight = !FacingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		//if (FacingRight == false){
			//localScale.x =2;
		//}
		transform.localScale = localScale;
		if (XMoveDirection > 0) {
			XMoveDirection = -1;
		}
		else {
			XMoveDirection = 1;
		}
	}
}
