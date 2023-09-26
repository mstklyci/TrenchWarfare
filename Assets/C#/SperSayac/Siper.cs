using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siper : MonoBehaviour
{
    //GameObject
    public GameObject SiperSayac1;
    public GameObject SiperSayac2;
    public GameObject SiperSayac3;
    public GameObject P2_SiperSayac1;
    public GameObject P2_SiperSayac2;
    public GameObject P2_SiperSayac3;

    //Ses
    public AudioClip Duduk_Sesi;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Duduk_Sesi;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (Sayac1.sayac1 > 0)
            {
                StartCoroutine(PrintAForThreeSeconds_1());

                AskerKod.M_siperkontrol1 = 1;
                M_Makineli.M_siperkontrol1 = 1;
                M_Sniper.M_siperkontrol1 = 1;
                El_Bombacisi.M_siperkontrol1 = 1;
                Tabancali.M_siperkontrol1 = 1;
            }
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (Sayac2.sayac2 > 0)
            {
                StartCoroutine(PrintAForThreeSeconds_2());

                AskerKod.M_siperkontrol2 = 1;
                M_Makineli.M_siperkontrol2 = 1;
                M_Sniper.M_siperkontrol2 = 1;
                El_Bombacisi.M_siperkontrol2 = 1;
                Tabancali.M_siperkontrol2 = 1;
            }
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            if (Sayac3.sayac3 > 0)
            {
                StartCoroutine(PrintAForThreeSeconds_3());

                AskerKod.M_siperkontrol3 = 1;
                M_Makineli.M_siperkontrol3 = 1;
                M_Sniper.M_siperkontrol3 = 1;
                El_Bombacisi.M_siperkontrol3 = 1;
                Tabancali.M_siperkontrol3 = 1;
            }
        }
        if (Input.GetKey(KeyCode.Keypad7))
        {
            if (KS1.P_2sayac1 > 0)
            {
                StartCoroutine(PrintAForThreeSeconds_P2_1());

                AskerKod.M_siperkontrol1 = 1;
                M_Makineli.M_siperkontrol1 = 1;
                M_Sniper.M_siperkontrol1 = 1;
                El_Bombacisi.M_siperkontrol1 = 1;
                Tabancali.M_siperkontrol1 = 1;
            }
        }
        if (Input.GetKey(KeyCode.Keypad8))
        {
            if (KS2.P2_sayac2> 0)
            {
                StartCoroutine(PrintAForThreeSeconds_P2_2());

                AskerKod.M_siperkontrol2 = 1;
                M_Makineli.M_siperkontrol2 = 1;
                M_Sniper.M_siperkontrol2 = 1;
                El_Bombacisi.M_siperkontrol2 = 1;
                Tabancali.M_siperkontrol2 = 1;
            }
        }
        if (Input.GetKey(KeyCode.Keypad9))
        {
            if (KS3.P2_sayac3 > 0)
            {
                StartCoroutine(PrintAForThreeSeconds_P2_3());

                AskerKod.M_siperkontrol3 = 1;
                M_Makineli.M_siperkontrol3 = 1;
                M_Sniper.M_siperkontrol3 = 1;
                El_Bombacisi.M_siperkontrol3 = 1;
                Tabancali.M_siperkontrol3 = 1;
            }
        }
    }
    private IEnumerator PrintAForThreeSeconds_1()
    {
        if (Sayac1.sayac1 > 0)
        {
            audioSource.Play();
        }

        float printDuration = 2f;
        float elapsedTime = 0f;

        while (elapsedTime < printDuration)
        {
            Sayac1.sayac1 = 0;
            SiperSayac1.SetActive(true);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
    private IEnumerator PrintAForThreeSeconds_2()
    {
        if (Sayac2.sayac2 > 0)
        {
            audioSource.Play();
        }

        float printDuration = 2f;
        float elapsedTime = 0f;

        while (elapsedTime < printDuration)
        {
            Sayac2.sayac2 = 0;
            SiperSayac2.SetActive(true);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
    private IEnumerator PrintAForThreeSeconds_3()
    {
        if (Sayac3.sayac3 > 0)
        {
            audioSource.Play();
        }

        float printDuration = 2f;
        float elapsedTime = 0f;

        while (elapsedTime < printDuration)
        {
            Sayac3.sayac3 = 0;
            SiperSayac3.SetActive(true);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
    private IEnumerator PrintAForThreeSeconds_P2_1()
    {
        if (KS1.P_2sayac1 > 0)
        {
            audioSource.Play();
        }

        float printDuration = 2f;
        float elapsedTime = 0f;

        while (elapsedTime < printDuration)
        {
            KS1.P_2sayac1 = 0;
            SiperSayac1.SetActive(true);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
    private IEnumerator PrintAForThreeSeconds_P2_2()
    {
        if (KS2.P2_sayac2> 0)
        {
            audioSource.Play();
        }

        float printDuration = 2f;
        float elapsedTime = 0f;

        while (elapsedTime < printDuration)
        {
            KS2.P2_sayac2 = 0;
            SiperSayac1.SetActive(true);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
    private IEnumerator PrintAForThreeSeconds_P2_3()
    {
        if (KS3.P2_sayac3 > 0)
        {
            audioSource.Play();
        }

        float printDuration = 2f;
        float elapsedTime = 0f;

        while (elapsedTime < printDuration)
        {
            KS3.P2_sayac3 = 0;
            SiperSayac1.SetActive(true);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}