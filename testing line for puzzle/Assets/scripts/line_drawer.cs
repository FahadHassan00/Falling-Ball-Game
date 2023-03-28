using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line_drawer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Camera cam;
    public line lineprefab;
    int begin;
    private line currentline;
    public const float resolution = 0.1f;
    public int lives = 0;
    public GameObject live1;
    public GameObject live2;
    public GameObject live3;
    public GameObject live4;
    public float speed;
    public GameObject gameoverpanel;
    public float time = 0f;
    public float timedelay = 8f;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        begin = 0;
        lives = 0;
    }

    //Update is called once per frame
    private void FixedUpdate()
    {
        time = time + 1f * Time.deltaTime;
        if (time >= timedelay)
        {
            if (speed < 0.2f)
            {
                gameoverpanel.SetActive(true);
                
            }
            else
            {
                time = 5f;
            }
            
            

        }
    }
    void Update()
    {
        speed = Mathf.Abs(rb.velocity.x);
        
        Vector2 mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        
        if (Input.GetMouseButtonDown(0))
        {
            if (lives == 5)
            {
                Debug.Log("gameover");
            }
            else
            {
                if (lives == 0)
                {
                    live4.SetActive(false);
                }
                if (lives == 1)
                {
                    live3.SetActive(false);
                }
                if (lives == 2)
                {
                    live2.SetActive(false);
                }
                if (lives == 3)
                {
                    live1.SetActive(false);
                }

                SoundManager.playsound("linedraw");
                currentline = Instantiate(lineprefab, mousepos, Quaternion.identity);
                lives++;
            }
        }
        if (Input.GetMouseButton(0))
        {
            if (lives == 5)
            {

            }
            else
            {


                currentline.setposition(mousepos);
                if (begin == 0)
                {
                    rb.velocity = new Vector2(3.5f, 0f);
                    begin++;
                }
            }
        }
    }
    
}
