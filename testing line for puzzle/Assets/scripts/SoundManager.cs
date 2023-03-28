using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    static AudioSource src;

    static AudioClip bounce, linedraw, gameover, levelcomplete,explosion;
    // Start is called before the first frame update
    void Start()

    {
        src = GetComponent<AudioSource>();
       
        gameover = Resources.Load<AudioClip>("levelfail");
        levelcomplete = Resources.Load<AudioClip>("levelcomplete");
        bounce = Resources.Load<AudioClip>("jump3");
        linedraw = Resources.Load<AudioClip>("linedraw");
        explosion = Resources.Load<AudioClip>("explosion");
    }

    public static void playsound(string clipname)
    {
        switch (clipname)
        {


            case "bounce":
                
                src.PlayOneShot(bounce);
                break;
            case "linedraw":
                
                src.PlayOneShot(linedraw);
                break;
            case "gameover":
                src.volume = 0.5f;
                src.PlayOneShot(gameover);
                break;
            case "levelcomplete":
                src.PlayOneShot(levelcomplete);
                break;
            case "explosion":
                src.PlayOneShot(explosion);
                break;

        }
    }
}
