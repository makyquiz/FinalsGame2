using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public GameObject trigger;
    public GameObject gem;

    private int trigCounter = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Triggers")
        {
            trigCounter++;
        }

        if (trigCounter == 1)
        {
            gem.SetActive(true);
        }
        
    }
}
