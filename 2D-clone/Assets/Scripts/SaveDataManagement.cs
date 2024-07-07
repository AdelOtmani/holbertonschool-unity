using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveDataManagement : MonoBehaviour {

	// Use this for initialization
	public static SaveDataManagement saveDataManagement;
	public int highScore;

	// Update is called once per frame
	void Awake (){
		if (saveDataManagement == null) {
			DontDestroyOnLoad (gameObject);
			saveDataManagement = this;
		}
		else if (saveDataManagement == this) {
			Destroy (gameObject);
		}
	}

	public void SaveData (){

	}

	public void LoadData (){

	}
}
