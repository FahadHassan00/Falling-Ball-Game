using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public GameObject levelcompletepanel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
            levelcompletepanel.SetActive(true);
            Destroy(collision.gameObject);
            Handheld.Vibrate();
            SoundManager.playsound("levelcomplete");
        }
        
    }
}
