using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectsline : MonoBehaviour
{

    public GameObject line, line1, line2, line3,gameover;
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 4;
        line.gameObject.SetActive(true);
        line1.gameObject.SetActive(true);
        line2.gameObject.SetActive(true);
        line3.gameObject.SetActive(true);
        //gameover.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health>4)
        {
            health =4;
        }
        switch(health)
        {
            case 4:
                line.gameObject.SetActive(true);
                line1.gameObject.SetActive(true);
                line2.gameObject.SetActive(true);
                line3.gameObject.SetActive(true);
              break;
            case 3:
                line.gameObject.SetActive(true);
                line1.gameObject.SetActive(true);
                line2.gameObject.SetActive(true);
                line3.gameObject.SetActive(false);
                break;
            case 2:
                line.gameObject.SetActive(true);
                line1.gameObject.SetActive(true);
                line2.gameObject.SetActive(false);
                line3.gameObject.SetActive(false);
                break;
            case 1:
                line.gameObject.SetActive(true);
                line1.gameObject.SetActive(false);
                line2.gameObject.SetActive(false);
                line3.gameObject.SetActive(false);
                break;
            case 0:
                line.gameObject.SetActive(false);
                line1.gameObject.SetActive(false);
                line2.gameObject.SetActive(false);
                line3.gameObject.SetActive(false);
               // Time.timescale = 0;
                break;
        }
    }
}
