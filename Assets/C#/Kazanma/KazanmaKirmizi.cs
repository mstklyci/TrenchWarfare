using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KazanmaKirmizi : MonoBehaviour
{
    public GameObject Kirmizi_kazandi;

    void Start()
    {
        Kirmizi_kazandi.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kirmizi_Takim")
        {
            Kirmizi_kazandi.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
