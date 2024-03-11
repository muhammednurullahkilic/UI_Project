using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{

    public GameObject goruntu, ses;



    // Start is called before the first frame update
    void Start()
    {
        ses.SetActive(false);
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





}  
