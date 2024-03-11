using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Scene : MonoBehaviour
{

    public GameObject homeButton, istatistikButton, settingsButton, envanterButton, TechizatButton, oynaButton, magazaButton, haberlerButton, exitButton, sound;
    public Slider soundSlider;

    
    public void SliderCheck()
    {
        sound.GetComponent<AudioSource>().volume = soundSlider.value;  
    }

   


    public void home()
    {
        SceneManager.LoadScene(0);
    }
  
    public void istatistik()
    {
        SceneManager.LoadScene(1);
    }

    public void settings()
    {
        SceneManager.LoadScene(2);
    }

    public void envanter()
    {
        SceneManager.LoadScene(3);
    }
    public void techizatCT()
    {
        SceneManager.LoadScene(4);
    }

    public void oyna()
    {
        SceneManager.LoadScene(5);
    }

    public void magaza()
    {
        SceneManager.LoadScene(6);
    }

    public void haberler()
    {
        SceneManager.LoadScene(7);
    }

    public void ExitGame()
    {
        Application.Quit();
    }



}
