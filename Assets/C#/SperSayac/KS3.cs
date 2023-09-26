using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KS3 : MonoBehaviour
{
    public static int P2_sayac3 = 0;

    public void Start()
    {
        P2_sayac3 = 0;
    }
    private void Update()
    {
        if (P2_sayac3 >= 5)
        {
            gameObject.SetActive(false);
        }
        else if (P2_sayac3 <= 0)
        {
            gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kirmizi_Takim")
        {
            P2_sayac3++;
        }
    }
}
