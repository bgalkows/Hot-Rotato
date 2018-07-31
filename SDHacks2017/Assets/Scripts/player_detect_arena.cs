using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_detect_arena : MonoBehaviour
{
    public bool platformActivated = false;
    public GameObject[] platform;
    public float counter;
    public LevelManager levelManager;

    private bool onPlatform = false;

    // Use this for initialization
    void Start()
    {
        platform = GameObject.FindGameObjectsWithTag("Platform");
        levelManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<LevelManager>();

        foreach (GameObject g in platform)
        {
            g.GetComponent<OriginalBackAndForth>().enabled = true;
            g.GetComponent<rotate_object_arena>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        userInput();

        checkForPlatform();
        if (onPlatform) { counter = 0f; }
        else { counter += Time.deltaTime; }
    }

    void checkForPlatform()
    {

    }

    void userInput()
    {
        if (Input.GetMouseButton(1))
        {
            Time.timeScale = 0.5f;
        }
        else
        {
            Time.timeScale = 1f;
        }

        Time.fixedDeltaTime = 0.02F * Time.timeScale;


    }
}
