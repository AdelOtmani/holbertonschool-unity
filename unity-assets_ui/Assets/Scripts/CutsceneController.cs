using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneController : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject player;
    public Canvas timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void InitGameStarter()
    {
        mainCamera.gameObject.SetActive(true);
        timer.gameObject.SetActive(true);
        player.GetComponent<PlayerController>().enabled = true;
        this.gameObject.SetActive(false);
    }
}
