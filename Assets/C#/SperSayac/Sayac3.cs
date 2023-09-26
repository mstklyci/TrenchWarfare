using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sayac3 : MonoBehaviour
{
    public static int sayac3 = 0;

    public void Start()
    {
        sayac3 = 0;
    }
    private void Update()
    {
        if (sayac3 >= 5)
        {
            gameObject.SetActive(false);
        }
        else if (sayac3 <= 0)
        {
            gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mavi_Takim")
        {
            sayac3++;
        }
    }
}
