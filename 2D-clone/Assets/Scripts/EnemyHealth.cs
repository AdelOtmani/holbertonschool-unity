using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	// Use this for initialization
	void Update () {
		if (gameObject.transform.position.y < -10) {
			//Debug.Log ("Player died");
			Destroy (gameObject);
		}
	}
}
