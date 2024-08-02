using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WinTrigger : MonoBehaviour {

	public GameObject player;
	public int size = 60;
	public Text timerText;
	// Use this for initialization
	private void OnTriggerEnter(Collider other)
	{
		player.GetComponent<Timer>().enabled = false;
		timerText.fontSize = size;
        timerText.color = Color.green;

	}
}
