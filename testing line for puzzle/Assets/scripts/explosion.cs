using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
     public GameObject _explosion;
    public GameObject gameoverpanel;
    // Start is called before the first frame update
    void Start()
    {
        //_explosion.SetActive(true)
;    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("bomb"))
        {
            _explosion.SetActive(true);
            Destroy(collision.gameObject);
            
            gameObject.SetActive(false);
            SoundManager.playsound("explosion");
            //SoundManager.playsound("gameover");
            //StartCoroutine("Delay");

        }
    }
    
   

    

    //IEnumerator Delay()
    //{

    //    yield return new WaitForSeconds(1f);
    //    gameoverpanel.SetActive(true);





    //}
}
