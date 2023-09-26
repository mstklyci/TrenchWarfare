using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private bool basildi = false;
    bool seslerAcik = true;
    public GameObject SettingsPanel;
    //Ses
    public AudioClip menu_muzik;    
    private AudioSource menuses;

    public void Start()
    {
        SettingsPanel.SetActive(false);

        menuses = GetComponent<AudioSource>();
        menuses.clip = menu_muzik;
    }
    void Update()
    {
        if (!menuses.isPlaying)
        {
            menuses.Play();
        }

        if (basildi)
            return;
    }
    public void SinglePlayerButton()
    {
        SceneManager.LoadScene(1);
    }
    public void LocalVS()
    {
        SceneManager.LoadScene(2);
    }
    public void SettingsButton()
    {
        basildi = !basildi;

        if (basildi)
        {
            SettingsPanel.SetActive(true);
        }
        else
        {
            SettingsPanel.SetActive(false);
        }            
    }
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
}