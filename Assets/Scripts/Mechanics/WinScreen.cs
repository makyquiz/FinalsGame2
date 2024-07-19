using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : MonoBehaviour
{

    public void LoadNextLevel()
    {

        FindFirstObjectByType<GameManager>().EndLevel();
    }
}
