using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    private GameObject[] Obstacles;
    private GameObject[] Box;

    // Start is called before the first frame update
    void Start()
    {
        Obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
        Box = GameObject.FindGameObjectsWithTag("Box");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Move(Vector2 direction)
    {
        if (BoxToBlocked(transform.position, direction))
        {
            return false;
        }
        else
        {
            transform.Translate(direction);
            return true;
        }
    }

    public bool BoxToBlocked(Vector3 pos, Vector2 direction)
    {
        Vector2 newpos = new Vector2(pos.x, pos.y) + direction;

        foreach (var obj in Obstacles)
        {
            if (obj.transform.position.x == newpos.x && obj.transform.position.y == newpos.y)
            {
                return true;
            }
        }

        foreach (var box in Box)
        {
            if (box.transform.position.x == newpos.x && box.transform.position.y == newpos.y)
            {
                return true;
            }
        }
        return false;
    }
}
