using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

public float sensitivity = 5;
public Transform player;
private Vector3 offset;

    // Update is called once per frame
void Update ()
	{
        transform.position = player.transform.position + new Vector3(0, 1, -10);
    }

void FixedUpdate ()
    {
		//with no right clic pressed
		offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensitivity, Vector3.up) * offset;
		Vector3 newPosition = player.position + offset;
		transform.position = newPosition;
        transform.LookAt(player.position);
		player.Rotate(Input.GetAxis("Mouse X") * sensitivity * Vector3.up);
		//if (Input.GetMouseButton(0)) use when the right clic is pressed
		//{
		//	float rotateHorizontal = Input.GetAxis ("Mouse X");
        //	transform.Rotate(player.transform.position * rotateHorizontal * sensitivity);

		//}

    }
}
