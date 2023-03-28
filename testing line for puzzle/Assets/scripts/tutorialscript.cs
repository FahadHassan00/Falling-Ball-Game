using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialscript : MonoBehaviour
{

    public GameObject tutorial;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Delay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Delay()
    {

        yield return new WaitForSeconds(3f);
        tutorial.SetActive(false);





    }
}
