using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KazanmaMavi : MonoBehaviour
{
    public GameObject Mavi_kazandi;

    void Start()
    {
        Mavi_kazandi.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mavi_Takim")
        {
            Mavi_kazandi.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
