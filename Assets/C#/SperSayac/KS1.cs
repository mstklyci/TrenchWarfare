using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KS1 : MonoBehaviour
{
    public static int P_2sayac1 = 0;

    public void Start()
    {
        P_2sayac1 = 0;
    }
    private void Update()
    {
        if (P_2sayac1 >= 5)
        {
            gameObject.SetActive(false);
        }
        else if (P_2sayac1 <= 0)
        {
            gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kirmizi_Takim")
        {
            P_2sayac1++;
        }
    }
}
