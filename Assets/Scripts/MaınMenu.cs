using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaınMenu : MonoBehaviour
{


    public GameObject RightOpenMenu, RightCloseMenu;
    


    // Start is called before the first frame update
    void Start()
    {
        RightOpenMenu.SetActive(false);
    }



   



    public void NextPanel()
    {
        if(RightCloseMenu.activeInHierarchy)
        {
            RightOpenMenu.SetActive(true);
            
        }
        
    }

    public void BackPanel()
    {
        if (RightOpenMenu.activeInHierarchy)
        {
            RightCloseMenu.SetActive(true);
            RightOpenMenu.SetActive(false );

        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
