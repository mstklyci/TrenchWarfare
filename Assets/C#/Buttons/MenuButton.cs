using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    bool seslerAcik = true;
    public void SesButton()
    {
        seslerAcik = !seslerAcik;
        if (seslerAcik)
        {
            AudioListener.volume = 1.0f;
        }
        else
        {
            AudioListener.volume = 0.0f;
        }
    }
    public void MenuDonus()
    {
        SceneManager.LoadScene(0);
    }
}
