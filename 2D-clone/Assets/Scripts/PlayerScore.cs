using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerScore : MonoBehaviour {

	public float timeLeft = 120;
	public int playerScore = 0;
	public GameObject timeLeftUI;
	public GameObject playerScoreUI;

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left : " + (int)timeLeft);
		playerScoreUI.gameObject.GetComponent<Text>().text = ("Score : " + playerScore);
		Debug.Log (timeLeft);
		if (timeLeft < 0.1f){
			SceneManager.LoadScene ("Main");
		}
	}

	void OnTriggerEnter2D (Collider2D trig) {
		if (trig.gameObject.name == "EndLevel"){
			CountScore ();
			SaveDataManagement.saveDataManagement.SaveData ();
		}
		if (trig.gameObject.tag == "coin") {
			playerScore += 10;
			Destroy (trig.gameObject);
		}
	}

	void CountScore () {
		playerScore = playerScore + (int)(timeLeft * 10);
		Debug.Log ("score is" + playerScore);
	}
}
