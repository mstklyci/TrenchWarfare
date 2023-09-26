using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sayac1 : MonoBehaviour
{
    public static int sayac1 = 0;

    public void Start()
    {
        sayac1 = 0;
    }
    private void Update()
    {
        if (sayac1 >= 5)
        {
            gameObject.SetActive(false);
        }
        else if (sayac1 <= 0)
        {
            gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mavi_Takim")
        {
            sayac1++;
        }       
    }
}