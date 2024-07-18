using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameManager gameManager;

    void Awake()
    {
        GameManager.triggersInLevel++;
    }

    private void Update()
    {
        Debug.Log("level triggers " + GameManager.triggersInLevel);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Box")
        {
            GameManager.triggersActivated += 1;
            Debug.Log("triggers activated " + GameManager.triggersActivated);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Box" )
        {
            GameManager.triggersActivated -= 1;
            Debug.Log("triggers activated " + GameManager.triggersActivated);
        }
    }
}
