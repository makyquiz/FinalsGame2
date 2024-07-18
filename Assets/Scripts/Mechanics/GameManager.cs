using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject gem;

    public static int triggersInLevel;
    public static int triggersActivated = 0;

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if(gameHasEnded == false)
            {
                gameHasEnded = true;
                Debug.Log("Restarted");
                Invoke("RestartLevel", restartDelay);
            }           
        }

        if (triggersActivated == triggersInLevel)
        {
            gem.SetActive(true);
        }
        else
        {
            gem.SetActive(false);
        }
    }


    public void EndLevel()
    {
        Invoke("NextLevel", restartDelay);
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        triggersInLevel = 0;
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        triggersInLevel = 0;
    }
}
