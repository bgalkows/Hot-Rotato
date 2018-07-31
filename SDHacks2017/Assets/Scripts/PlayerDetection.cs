using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDetection : MonoBehaviour {
    public bool platformActivated = false;
    public GameObject[] platform;
    public float counter;
    public LevelManager levelManager;

    private bool onPlatform = false;

	// Use this for initialization
	void Start () {
        platform = GameObject.FindGameObjectsWithTag("Platform");
        levelManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (counter >= 4.0f && platformActivated)
        {
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                SceneManager.LoadScene("Defeat");
            }
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                SceneManager.LoadScene("Defeat 2");
            }
            if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                SceneManager.LoadScene("Defeat 3");
            }
            if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                SceneManager.LoadScene("Defeat 4");
            }
            if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                SceneManager.LoadScene("Defeat 5");
            }
        } 

        userInput();

        checkForPlatform();
        if (onPlatform) { counter = 0f; }
        else { counter += Time.deltaTime; }
	}

    void checkForPlatform()
    {
        RaycastHit ray;


        if(Physics.Raycast(this.transform.position, Vector3.down, out ray))
        {
            if(ray.collider.gameObject.tag == "Platform")
            {
                if(!platformActivated)
                {
                    foreach(GameObject g in platform)
                    {
                        g.GetComponent<OriginalBackAndForth>().enabled = true;
                        g.GetComponent<RotateObject>().enabled = true;
                    }

                    platformActivated = true;
                }
                onPlatform = true;
            }
            else
            {
                onPlatform = false;
            }

            if (ray.collider.gameObject.GetComponent<Terrain>() && transform.position.y <= 100.98f)
            {
                if(SceneManager.GetActiveScene().buildIndex == 4)
                {
                    SceneManager.LoadScene("Defeat");
                }
                if(SceneManager.GetActiveScene().buildIndex == 5)
                {
                    SceneManager.LoadScene("Defeat 2");
                }
                if(SceneManager.GetActiveScene().buildIndex == 6)
                {
                    SceneManager.LoadScene("Defeat 3");
                }
                if(SceneManager.GetActiveScene().buildIndex == 7)
                {
                    SceneManager.LoadScene("Defeat 4");
                }
                if(SceneManager.GetActiveScene().buildIndex == 8)
                {
                    SceneManager.LoadScene("Defeat 5");
                }
            }
        }
    }

    void userInput()
    {
        if( Input.GetMouseButton(1))
        {
            Time.timeScale = 0.5f;
        }
        else
        {
            Time.timeScale = 1f;
        }

        Time.fixedDeltaTime = 0.02F * Time.timeScale;

        if ( Input.GetKeyUp(KeyCode.E))
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Finish"  && platformActivated)
        {
            levelManager.nextLevel();
        }
    }

}
