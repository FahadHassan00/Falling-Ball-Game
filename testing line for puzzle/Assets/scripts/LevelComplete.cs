using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class LevelComplete : MonoBehaviour
{
    public GameObject LevelComp;
    // Start is called before the first frame update
    void Start()
    {
        LevelComp.SetActive(false);
    }
    public void nextlevel(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
