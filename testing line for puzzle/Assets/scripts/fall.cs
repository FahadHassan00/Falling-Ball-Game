using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    public GameObject gameoverpanel;

    private void Start()
    {
        //gameoverpanel = GameObject.Find("GameOverPanel");
    } 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
            gameoverpanel.SetActive(true);
            Debug.Log("hello");
            //SoundManager.playsound("gameover");
        }
    }
}
