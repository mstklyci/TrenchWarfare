using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ses_Manager : MonoBehaviour
{ 
    //Ses
    public AudioClip Oyun_ici_muzik;
    private AudioSource oyunicises;

    void Start()
    {
        oyunicises = GetComponent<AudioSource>();
        oyunicises.clip = Oyun_ici_muzik;
    }
    void Update()
    {
        if (!oyunicises.isPlaying)
        {
            oyunicises.Play();
        }
    }
}