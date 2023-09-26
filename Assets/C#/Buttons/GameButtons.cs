using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject MenuPanel;

    //Ses
    public AudioClip Reload_Sesi;
    private AudioSource audioSource;

    public void Start()
    {
        Time.timeScale = 1f;
        MenuPanel.SetActive(false);

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Reload_Sesi;
    }
    void Update()
    {
        if (isPaused)
            return;
    }
    public void OnPauseButtonClicked()
    {
        audioSource.Play();
        isPaused = !isPaused;

        if (isPaused)
        {
            MenuPanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            MenuPanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
