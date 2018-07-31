using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public int currentTrace = 0;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void loadLevel( string sceneName )
    {
        if(sceneName == "Defeat")
        {
            UnityEngine.Cursor.visible = true;
        }
        SceneManager.LoadScene(sceneName);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void loadWithTrace( string sceneName, int trace)
    {
        currentTrace = trace;
        SceneManager.LoadScene(sceneName);
    }

    public void tryAgain()
    {
        SceneManager.LoadScene(currentTrace);
    }
}
