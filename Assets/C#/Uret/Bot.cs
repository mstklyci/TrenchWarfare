using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    //DusmanGameObject
    public GameObject K_Asker;
    public GameObject K_Makineli;
    public GameObject K_Yakin;
    public GameObject K_Sniper;
    public GameObject K_Tabanca;

    public bool secim = true;

    private void Update()
    {
        if (secim == true)
        {
            float randomValue = Random.value;

            if (randomValue <= 0.2f)
            {
                StartCoroutine(AskerBasimSure());
                secim = false;
            }
            else if (randomValue <= 0.4f)
            {
                StartCoroutine(MakineliBasimSure());
                secim = false;
            }
            else if (randomValue <= 0.6f)
            {
                StartCoroutine(YakinBasimSure());
                secim = false;
            }
            else if (randomValue <= 0.8f)
            {
                StartCoroutine(SniperBasimSure());
                secim = false;
            }
            else
            {
                StartCoroutine(TabancaBasimSure());
                secim = false;
            }
        }
    }
    IEnumerator AskerBasimSure()
    {
        float randomZ = Random.Range(-3f, 10f);

        yield return new WaitForSeconds(10f);
        Instantiate(K_Asker, new Vector3(68f, 6f, randomZ), Quaternion.Euler(0f, -90f, 0f));
        secim = true;
    }
    IEnumerator MakineliBasimSure()
    {
        float randomZ = Random.Range(-3f, 10f);

        yield return new WaitForSeconds(20f);
        Instantiate(K_Makineli, new Vector3(68f, 6f, randomZ), Quaternion.Euler(0f, -90f, 0f));
        secim = true;
    }
    IEnumerator YakinBasimSure()
    {
        float randomZ = Random.Range(-3f, 10f);

        yield return new WaitForSeconds(10f);
        Instantiate(K_Yakin, new Vector3(68f, 6f, randomZ), Quaternion.Euler(0f, -90f, 0f));
        secim = true;
    }
    IEnumerator SniperBasimSure()
    {
        float randomZ = Random.Range(-3f, 10f);

        yield return new WaitForSeconds(30f);
        Instantiate(K_Sniper, new Vector3(68f, 6f, randomZ), Quaternion.Euler(0f, -90f, 0f));
        secim = true;
    }
    IEnumerator TabancaBasimSure()
    {
        float randomZ = Random.Range(-3f, 10f);

        yield return new WaitForSeconds(15f);
        Instantiate(K_Tabanca, new Vector3(68f, 6f, randomZ), Quaternion.Euler(0f, -90f, 0f));
        secim = true;
    }
}