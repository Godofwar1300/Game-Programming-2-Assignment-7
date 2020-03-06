using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject RemoteController;
    public GameObject player;
    public Camera overheadCamera;

    private bool isUsingControls;


    // Start is called before the first frame update
    void Start()
    {
        overheadCamera.gameObject.SetActive(false);
        RemoteController.SetActive(false);
        isUsingControls = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.H) && !isUsingControls)
        {
            player.SetActive(false);
            overheadCamera.gameObject.SetActive(true);
            isUsingControls = true;
            RemoteController.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.H) && isUsingControls)
        {
            overheadCamera.gameObject.SetActive(false);
            player.SetActive(true);
            isUsingControls = false;
            RemoteController.SetActive(false);
        }


    }
}
