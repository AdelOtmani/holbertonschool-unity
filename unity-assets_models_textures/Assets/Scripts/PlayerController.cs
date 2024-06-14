using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1500f;
	public Rigidbody Rb;
	public float jumpforce = 10;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	    if (Input.GetKey(KeyCode.W))
        {
            Rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
		if (Input.GetKey(KeyCode.D))
        {
            Rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
		if (Input.GetKey(KeyCode.Space))
		{
			Rb.AddForce(Vector3.up * jumpforce);
		}
	}
}
