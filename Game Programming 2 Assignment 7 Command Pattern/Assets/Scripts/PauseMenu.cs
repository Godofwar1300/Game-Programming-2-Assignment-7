using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenuPanel;

    private bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenuPanel.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            PauseGame();
            Debug.Log("This button is being pressed!");
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            UnPauseGame();
        }
    }

    public void PauseGame()
    {
        pauseMenuPanel.SetActive(true);
        isPaused = true;
        Time.timeScale = 00000001f;
    } 
    public void UnPauseGame()
    {
        pauseMenuPanel.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
    }

}
