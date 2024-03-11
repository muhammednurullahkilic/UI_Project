using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class deneme : MonoBehaviour
{
    public GameObject RightOpenMenu, RightCloseMenu, homeButton, istatistikButton, settingsButton, envanterButton, TechizatButton, oynaButton, magazaButton, haberlerButton, exitButton,
        goruntu, ses,sound,techizatPanel,oynaPanel,magazaPanel,istatistikPanel,envanterPanel,haberlerPanel,settinsPanel,ayarlarAltPanel,sesPanel,GoruntuPanel,menuPanel;

    public Slider soundSlider;

    public void SliderCheck()
    {
        sound.GetComponent<AudioSource>().volume = soundSlider.value;
    }
    // Start is called before the first frame update
    void Start()
    {
        goruntu.SetActive(false);
        ses.SetActive(false);
        RightOpenMenu.SetActive(false);
        techizatPanel.SetActive(false);
        oynaPanel.SetActive(false);
        magazaPanel.SetActive(false);
        istatistikPanel.SetActive(false);
        envanterPanel.SetActive(false);
        haberlerPanel.SetActive(false);
        settinsPanel.SetActive(false);
        ayarlarAltPanel.SetActive(false);
        sesPanel.SetActive(false);
        GoruntuPanel.SetActive(false);
        
    }

    public void panelChange()
    {




        if(menuPanel.activeInHierarchy)
        {
            techizatPanel.SetActive(false);
            settinsPanel.SetActive(false);
            ayarlarAltPanel.SetActive(false);
            sesPanel.SetActive(false);
            oynaPanel.SetActive(false);
            magazaPanel.SetActive(false);
            istatistikPanel.SetActive(false);
            envanterPanel.SetActive(false);
            GoruntuPanel.SetActive(false);
            haberlerPanel.SetActive(false);
        }

                
     else if (techizatPanel.activeInHierarchy)
        {
            settinsPanel.SetActive(false );
            ayarlarAltPanel.SetActive(false );
            sesPanel.SetActive(false );
            oynaPanel.SetActive (false );
            magazaPanel.SetActive(false ); 
            istatistikPanel .SetActive(false );
            envanterPanel.SetActive(false);
            GoruntuPanel .SetActive(false);
            haberlerPanel.SetActive(false);
        }
     else if(settinsPanel.activeInHierarchy)
        {
            techizatPanel .SetActive(false );
            ayarlarAltPanel.SetActive(true);
            sesPanel.SetActive(false);
            oynaPanel.SetActive(false);
            magazaPanel.SetActive(false);
            istatistikPanel.SetActive(false);
            envanterPanel.SetActive(false);
            GoruntuPanel.SetActive(true);
            haberlerPanel.SetActive(false);
        }
        else if (ayarlarAltPanel.activeInHierarchy)
        {
            techizatPanel.SetActive(false);
            settinsPanel.SetActive(false);
            sesPanel.SetActive(false);
            oynaPanel.SetActive(false);
            magazaPanel.SetActive(false);
            istatistikPanel.SetActive(false);
            envanterPanel.SetActive(false);
            GoruntuPanel.SetActive(true);
            haberlerPanel.SetActive(false);
        }
        else if (sesPanel.activeInHierarchy)
        {
            techizatPanel.SetActive(false);
            settinsPanel.SetActive(false);
            ayarlarAltPanel.SetActive(true);
            oynaPanel.SetActive(false);
            magazaPanel.SetActive(false);
            istatistikPanel.SetActive(false);
            envanterPanel.SetActive(false);
            GoruntuPanel.SetActive(false);
            haberlerPanel.SetActive(false);
        }
        else if (GoruntuPanel.activeInHierarchy)
        {
            techizatPanel.SetActive(false);
            settinsPanel.SetActive(false);
            ayarlarAltPanel.SetActive(true);
            oynaPanel.SetActive(false);
            magazaPanel.SetActive(false);
            istatistikPanel.SetActive(false);
            envanterPanel.SetActive(false);
            sesPanel.SetActive(false);
            haberlerPanel.SetActive(false);
        }
        else if (oynaPanel.activeInHierarchy)
        {
            techizatPanel.SetActive(false);
            settinsPanel.SetActive(false);
            sesPanel.SetActive(false);
            ayarlarAltPanel.SetActive(false);
            magazaPanel.SetActive(false);
            istatistikPanel.SetActive(false);
            envanterPanel.SetActive(false);
            GoruntuPanel.SetActive(false);
            haberlerPanel.SetActive(false);
        }
        else if (haberlerPanel.activeInHierarchy)
        {
            techizatPanel.SetActive(false);
            settinsPanel.SetActive(false);
            sesPanel.SetActive(false);
            oynaPanel.SetActive(false);
            magazaPanel.SetActive(false);
            istatistikPanel.SetActive(false);
            envanterPanel.SetActive(false);
            GoruntuPanel.SetActive(false);
            ayarlarAltPanel.SetActive(false);
        }
        else if (envanterPanel.activeInHierarchy)
        {
            techizatPanel.SetActive(false);
            settinsPanel.SetActive(false);
            sesPanel.SetActive(false);
            oynaPanel.SetActive(false);
            magazaPanel.SetActive(false);
            istatistikPanel.SetActive(false);
            ayarlarAltPanel.SetActive(false);
            GoruntuPanel.SetActive(false);
            haberlerPanel.SetActive(false);
        }
        else if (magazaPanel.activeInHierarchy)
        {
            techizatPanel.SetActive(false);
            settinsPanel.SetActive(false);
            sesPanel.SetActive(false);
            oynaPanel.SetActive(false);
            ayarlarAltPanel.SetActive(false);
            istatistikPanel.SetActive(false);
            envanterPanel.SetActive(false);
            GoruntuPanel.SetActive(false);
            haberlerPanel.SetActive(false);
        }
        else if (istatistikPanel.activeInHierarchy)
        {
            techizatPanel.SetActive(false);
            settinsPanel.SetActive(false);
            sesPanel.SetActive(false);
            oynaPanel.SetActive(false);
            magazaPanel.SetActive(false);
            ayarlarAltPanel.SetActive(false);
            envanterPanel.SetActive(false);
            GoruntuPanel.SetActive(false);
            haberlerPanel.SetActive(false);
        }






    }



    

    public void NextPanel()
    {
        if (RightCloseMenu.activeInHierarchy)
        {
            RightOpenMenu.SetActive(true);
            RightCloseMenu.SetActive(false);
        }

    }

    public void BackPanel()
    {
        if (RightOpenMenu.activeInHierarchy)
        {
            RightCloseMenu.SetActive(true);
            RightOpenMenu.SetActive(false);

        }

       
    }

    public void goruntuButton()
    {
        goruntu.SetActive(true);
        ses.SetActive(false);
    }

    public void sesButton()
    {
        ses.SetActive(true);
        goruntu.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }


}
