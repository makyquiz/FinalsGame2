using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if(gameHasEnded == false)
            {
                gameHasEnded = true;
                Debug.Log("Restarted");
                RestartLevel();
            }           
        }
    }

    public void EndLevel()
    {
        Invoke("NextLevel", restartDelay);
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
