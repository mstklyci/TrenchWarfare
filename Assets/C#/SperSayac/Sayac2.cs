using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sayac2 : MonoBehaviour
{
    public static int sayac2 = 0;

    public void Start()
    {
        sayac2 = 0;
    }
    private void Update()
    {
        if (sayac2 >= 5)
        {
            gameObject.SetActive(false);
        }
        else if (sayac2 <= 0)
        {
            gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mavi_Takim")
        {
            sayac2++;
        }
    }
}
