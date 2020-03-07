/*
* (Christopher Green)
* (GameController.cs)
* (Assignment 7)
* (This script handles the basic game functions)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject RemoteController;
    public GameObject player;
    public Camera overheadCamera;

    private bool isUsingControls;

    public Text coinText;

    public GameObject tutorialScreen;
    public Text tutorialTimer;
    private float duration = 0;

    // Start is called before the first frame update
    void Start()
    {
        overheadCamera.gameObject.SetActive(false);
        RemoteController.SetActive(false);
        isUsingControls = false;

        StartCoroutine(TutorialTimer());
    }

    // Update is called once per frame
    void Update()
    {

        coinText.text = "Total Coins: " + AddScore.totalScore;

        if (Input.GetKeyDown(KeyCode.H) && !isUsingControls)
        {
            player.SetActive(false);
            overheadCamera.gameObject.SetActive(true);
            isUsingControls = true;
            RemoteController.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.H) && isUsingControls)
        {
            overheadCamera.gameObject.SetActive(false);
            player.SetActive(true);
            isUsingControls = false;
            RemoteController.SetActive(false);
        }

        if(player.transform.position.y <= -40)
        {
            Death();
        }

        if(AddScore.totalScore == 4)
        {
            Win();
        }

    }

    public void Death()
    {
        SceneManager.LoadScene(2);
    }

    public void Win()
    {
        SceneManager.LoadScene(3);
    }

    public IEnumerator TutorialTimer()
    {
        duration = 10f;
        tutorialScreen.SetActive(true);
        player.SetActive(false);

        while (duration > 0)
        {
            duration -= Time.deltaTime;
            tutorialTimer.text = "Tutorial Timer: " + duration.ToString("00");
            yield return null;
        }

        if(duration <= 0)
        {
            tutorialScreen.SetActive(false);
            player.SetActive(true);
        }
    }

}
