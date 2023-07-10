using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Text timerText;
    public Timer timerScript;
    public GameObject player;
    public GameObject timerCanvas;
    public GameObject winCanvas;

    // Start is called before the first frame update
    void Start()
    {
       timerScript = player.GetComponent<Timer>();
    }

    // When player touches flag
    void OnTriggerEnter(Collider collider)
    {
        // Update final win time
        timerScript.Win();

        // Hide the timer canvas
        timerCanvas.gameObject.SetActive(false);

        // Display the win canvas
        winCanvas.gameObject.SetActive(true);

    }
}

// (OLD) before win canvas
/*public class WinTrigger : MonoBehaviour {

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
}*/
