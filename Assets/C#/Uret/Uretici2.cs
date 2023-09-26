using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uretici2 : MonoBehaviour
{
    //image
    public Image Y_image;
    public Image A_image;
    public Image T_image;
    public Image M_image;
    public Image S_image;

    //Asker GameObject
    public GameObject M_Asker;
    public GameObject M_Makineli;
    public GameObject M_Yakin;
    public GameObject M_Sniper;
    public GameObject M_Tabanca;

    //Uretim Suresi
    private float Y_Timer = 11f;
    private float A_Timer = 11f;
    private float T_Timer = 16f;
    private float M_Timer = 21f;
    private float S_Timer = 31f;

    //sesler
    public AudioClip birlik_üretim_ses1;
    public AudioClip birlik_üretim_ses2;
    public AudioClip birlik_üretim_ses3;

    void Start()
    {
        A_Timer = 0f;
        M_Timer = 0f;
        Y_Timer = 0f;
        S_Timer = 0f;
        T_Timer = 0f;
    }
    void Update()
    {
        A_Timer -= Time.deltaTime;
        M_Timer -= Time.deltaTime;
        Y_Timer -= Time.deltaTime;
        S_Timer -= Time.deltaTime;
        T_Timer -= Time.deltaTime;

        Y_image.fillAmount = Y_Timer / 11f;
        A_image.fillAmount = A_Timer / 11f;
        T_image.fillAmount = T_Timer / 16f;
        M_image.fillAmount = M_Timer / 21f;
        S_image.fillAmount = S_Timer / 31f;

        if (A_Timer <= 0)
        {
            A_Timer = 0;
        }
        if (M_Timer <= 0)
        {
            M_Timer = 0;
        }
        if (Y_Timer <= 0)
        {
            Y_Timer = 0;
        }
        if (S_Timer <= 0)
        {
            S_Timer = 0;
        }
        if (T_Timer <= 0)
        {
            T_Timer = 0;
        }

        //Spawn
        if (Input.GetKey(KeyCode.Keypad1))
        {
            if (Y_Timer <= 0)
            {
                float randomZ = Random.Range(-3f, 9f);
                Instantiate(M_Yakin, new Vector3(68f, 6f, randomZ), Quaternion.Euler(0f, 90f, 0f));
                AudioSource.PlayClipAtPoint(birlik_üretim_ses1, transform.position);
                Y_Timer = 11;
                A_Timer = 11;
                T_Timer = 16;
                M_Timer = 21;
                S_Timer = 31;
            }
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            if (A_Timer <= 0)
            {
                float randomZ = Random.Range(-3f, 9f);
                Instantiate(M_Asker, new Vector3(68f, 6f, randomZ), Quaternion.Euler(0f, 90f, 0f));
                AudioSource.PlayClipAtPoint(birlik_üretim_ses2, transform.position);
                Y_Timer = 11;
                A_Timer = 11;
                T_Timer = 16;
                M_Timer = 21;
                S_Timer = 31;
            }
        }
        if (Input.GetKey(KeyCode.Keypad3))
        {
            if (T_Timer <= 0)
            {
                float randomZ = Random.Range(-3f, 9f);
                Instantiate(M_Tabanca, new Vector3(68f, 6f, randomZ), Quaternion.Euler(0f, 90f, 0f));
                AudioSource.PlayClipAtPoint(birlik_üretim_ses3, transform.position);
                Y_Timer = 11;
                A_Timer = 11;
                T_Timer = 16;
                M_Timer = 21;
                S_Timer = 31;
            }
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            if (M_Timer <= 0)
            {
                float randomZ = Random.Range(-3f, 9f);
                Instantiate(M_Makineli, new Vector3(68f, 6f, randomZ), Quaternion.Euler(0f, 90f, 0f));
                AudioSource.PlayClipAtPoint(birlik_üretim_ses2, transform.position);
                Y_Timer = 11;
                A_Timer = 11;
                T_Timer = 16;
                M_Timer = 21;
                S_Timer = 31;
            }
        }
        if (Input.GetKey(KeyCode.Keypad5))
        {
            if (S_Timer <= 0)
            {
                float randomZ = Random.Range(-3f, 9f);
                Instantiate(M_Sniper, new Vector3(68f, 6f, randomZ), Quaternion.Euler(0f, 90f, 0f));
                AudioSource.PlayClipAtPoint(birlik_üretim_ses1, transform.position);
                Y_Timer = 11;
                A_Timer = 11;
                T_Timer = 16;
                M_Timer = 21;
                S_Timer = 31;
            }
        }
    }
}