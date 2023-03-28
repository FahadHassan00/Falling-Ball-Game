using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public Slider volslider;
    public AudioMixer mixer;
    private float value;
    private void start()
    {
         mixer.GetFloat("Volume",out value);
        volslider.value = value;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void LoadGame()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {

        Application.Quit();
    }
    public void setVolume()
    {
        mixer.SetFloat("Volume", volslider.value);

    }

}
