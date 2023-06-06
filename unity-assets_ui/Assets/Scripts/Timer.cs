using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

	public Text TimerText;
    private float timer = 0.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
        TimerText.text = string.Format("{0:0}:{1:00}.{2:00}", timer / 60, timer % 60, timer * 100 % 100);
	}
}
