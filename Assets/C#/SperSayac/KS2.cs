using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KS2 : MonoBehaviour
{
    public static int P2_sayac2 = 0;

    public void Start()
    {
        P2_sayac2 = 0;
    }
    private void Update()
    {
        if (P2_sayac2 >= 5)
        {
            gameObject.SetActive(false);
        }
        else if (P2_sayac2 <= 0)
        {
            gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kirmizi_Takim")
        {
            P2_sayac2++;
        }
    }
}
