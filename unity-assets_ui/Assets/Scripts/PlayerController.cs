using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1500f;
	public Rigidbody Rb;
	public float jumpforce = 10;
    public Vector3 startPosition;
    public Transform player;
	// Use this for initialization
	void Start () {
        startPosition = player.position;
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.D))
        {
            Rb.AddForce(speed * Time.deltaTime, 0, 0).Normalize;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Rb.AddForce(-speed * Time.deltaTime, 0, 0).Normalize;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Rb.AddForce(0, 0, speed * Time.deltaTime).Normalize;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Rb.AddForce(0, 0, -speed * Time.deltaTime).Normalize;
        }
		if (Input.GetKey(KeyCode.Space))
		{
			Rb.AddForce(Vector3.up * jumpforce).Normalize;
		}

        if (player.position.y < -20)
        {
           player.position = new Vector3(startPosition.x, startPosition.y + 15, startPosition.z);
        }
	}
}
