using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Mermi : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
    void Update()
    {
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }
    private void OnTriggerEnter(Collider nesne)
    {
        if (nesne.gameObject.CompareTag("Mavi_Takim"))
        {
            AskerKod insan = nesne.gameObject.GetComponent<AskerKod>();
            M_Makineli m_Makineli = nesne.gameObject.GetComponent<M_Makineli>();
            M_Yakin m_Yakin = nesne.gameObject.GetComponent<M_Yakin>();
            M_Sniper m_Sniper = nesne.gameObject.GetComponent<M_Sniper>();
            El_Bombacisi el_Bombacisi = nesne.gameObject.GetComponent<El_Bombacisi>();
            Tabancali tabancali = nesne.gameObject.GetComponent<Tabancali>();

            if (insan != null)
            {
                insan.Askencan(5);
            }
            if (m_Makineli != null)
            {
                m_Makineli.Askencan(5);
            }
            if (m_Yakin != null)
            {
                m_Yakin.Askencan(5);
            }
            if (m_Sniper != null)
            {
                m_Sniper.Askencan(5);
            }
            if (el_Bombacisi != null)
            {
                el_Bombacisi.Askencan(5);
            }
            if (tabancali != null)
            {
                tabancali.Askencan(5);
            }

            Destroy(gameObject);
        }
        else
        {
        }
        if (nesne.gameObject.tag == "Kirmizi_Takim")
        {
            AskerKod insan = nesne.gameObject.GetComponent<AskerKod>();
            M_Makineli k_Makineli = nesne.gameObject.GetComponent<M_Makineli>();
            M_Yakin k_Yakin = nesne.gameObject.GetComponent<M_Yakin>();
            M_Sniper k_Sniper = nesne.gameObject.gameObject.GetComponent<M_Sniper>();
            El_Bombacisi k_el_Bombacisi = nesne.gameObject.GetComponent<El_Bombacisi>();
            Tabancali k_tabancali = nesne.gameObject.GetComponent<Tabancali>();

            if (insan != null)
            {
                insan.Askencan(5);
            }
            if (k_Makineli != null)
            {
                k_Makineli.Askencan(5);
            }
            if (k_Yakin != null)
            {
                k_Yakin.Askencan(5);
            }
            if (k_Sniper != null)
            {
                k_Sniper.Askencan(5);
            }
            if (k_el_Bombacisi != null)
            {
                k_el_Bombacisi.Askencan(5);
            }
            if (k_tabancali != null)
            {
                k_tabancali.Askencan(5);
            }

            Destroy(gameObject);
        }
        else
        {
        }
    }
}