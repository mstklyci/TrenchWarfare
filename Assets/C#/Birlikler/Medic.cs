using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class Medic : MonoBehaviour
{
    //Konum
    public Transform namluucu, namlu, mermi;
    Transform klon;

    //Taglar
    public string targetTag = "";

    //SayisalDeger
    public float yon;
    private float moveSpeed = 10f;
    private float mesafe = 3f;
    private float M_medic_can = 10f;

    //Ses
    public AudioClip Olme_Sesi;

    //SiperKontrol
    public static int M_siperkontrol1 = 0;
    public static int M_siperkontrol2 = 0;
    public static int M_siperkontrol3 = 0;
    //S�re
    private float timer = 0f;

    //DusmanBakma
    private Transform DusmanBakma;

    //Animator
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        //Degerler
        Vector3 targetPosition = new Vector3(0f, 0f, 0.4f);
        transform.Translate(targetPosition * moveSpeed * Time.deltaTime);
        mesafe = KirmiziTakim();
        timer += Time.deltaTime;

        //DusmanBakma
        GameObject[] dusObjeleri = GameObject.FindGameObjectsWithTag(targetTag);
        float enYakinMesafe = Mathf.Infinity;
        GameObject enYakinObje = null;

        if (enYakinObje == null)
        {
            transform.rotation = Quaternion.Euler(0f, yon, 0f);
        }

        foreach (GameObject dusObje in dusObjeleri)
        {
            float mesafe = Vector3.Distance(transform.position, dusObje.transform.position);

            if (mesafe < enYakinMesafe)
            {
                enYakinMesafe = mesafe;
                enYakinObje = dusObje;
            }
        }

        //Olme
        if (M_medic_can <= 0 && anim.GetInteger("Hareket") == 0
            || M_medic_can <= 0 && anim.GetInteger("Hareket") == 2
            || M_medic_can <= 0 && anim.GetInteger("Hareket") == 7)
        {
            moveSpeed = 0f;
            anim.SetInteger("Hareket", 8);
            StartCoroutine(DestroyAfterAnimation());
        }

        //Ates
        if (mesafe <= 3)
        {
            if (enYakinObje != null)
            {
                DusmanBakma = enYakinObje.transform;
                transform.LookAt(DusmanBakma);
            }
            moveSpeed = 0f;
            anim.SetInteger("Hareket", 6);

            if (timer >= 1.5f)
            {
                klon = Instantiate(mermi, namluucu.position, namlu.rotation);
                klon.GetComponent<Rigidbody>().AddForce(klon.forward * 500f);
                timer = 0f;
            }

            if (M_medic_can <= 0)
            {
                moveSpeed = 0f;
                anim.SetInteger("Hareket", 9);
                StartCoroutine(DestroyAfterAnimation());
            }
        }
        else if (mesafe > 3 && anim.GetInteger("Hareket") == 6)
        {
            moveSpeed = 10f;
            anim.SetInteger("Hareket", 7);
        }
    }
    private void OnTriggerEnter(Collider nesne)
    {
        //DusmanaBakma
        GameObject[] dusObjeleri = GameObject.FindGameObjectsWithTag(targetTag);
        float enYakinMesafe = Mathf.Infinity;
        GameObject enYakinObje = null;

        foreach (GameObject dusObje in dusObjeleri)
        {
            float mesafe = Vector3.Distance(transform.position, dusObje.transform.position);

            if (mesafe < enYakinMesafe)
            {
                enYakinMesafe = mesafe;
                enYakinObje = dusObje;
            }
        }
        //SiperGiris
        if (nesne.gameObject.tag == "Siper1" || nesne.gameObject.tag == "Siper2" || nesne.gameObject.tag == "Siper3")
        {
            anim.SetInteger("Hareket", 1);
            moveSpeed = 0f;
            M_siperkontrol1 = 0;
            M_siperkontrol2 = 0;
            M_siperkontrol3 = 0;
        }
    }
    private void OnTriggerStay(Collider nesne)
    {
        //DusmanBakma
        GameObject[] dusObjeleri = GameObject.FindGameObjectsWithTag(targetTag);

        float enYakinMesafe = Mathf.Infinity;
        GameObject enYakinObje = null;

        foreach (GameObject dusObje in dusObjeleri)
        {
            float mesafe = Vector3.Distance(transform.position, dusObje.transform.position);

            if (mesafe < enYakinMesafe)
            {
                enYakinMesafe = mesafe;
                enYakinObje = dusObje;
            }
        }

        //SiperBekleme
        if (nesne.gameObject.tag == "Siper1")
        {
            if (M_siperkontrol1 == 1)
            {
                SiperKomutuCalistir(nesne.gameObject);
            }
            else if (mesafe <= 3)
            {
                if (enYakinObje != null)
                {
                    DusmanBakma = enYakinObje.transform;
                    transform.LookAt(DusmanBakma);
                }

                moveSpeed = 0f;
                anim.SetInteger("Hareket", 4);

                if (timer >= 1.5f)
                {
                    klon = Instantiate(mermi, namluucu.position, namlu.rotation);
                    klon.GetComponent<Rigidbody>().AddForce(klon.forward * 500f);
                    timer = 0f;
                }
            }
            //Olme
            else if (M_medic_can <= 0)
            {
                moveSpeed = 0f;
                anim.SetInteger("Hareket", 3);
                StartCoroutine(DestroyAfterAnimation());
            }
            //Devam
            else if (mesafe > 3 && anim.GetInteger("Hareket") == 4)
            {
                anim.SetInteger("Hareket", 5);
            }
            else
            {
                moveSpeed = 0f;
                anim.SetInteger("Hareket", 1);
            }
        }
        if (nesne.gameObject.tag == "Siper2")
        {
            if (M_siperkontrol2 == 1)
            {
                SiperKomutuCalistir(nesne.gameObject);
            }
            else if (mesafe <= 3)
            {
                if (enYakinObje != null)
                {
                    DusmanBakma = enYakinObje.transform;
                    transform.LookAt(DusmanBakma);
                }

                moveSpeed = 0f;
                anim.SetInteger("Hareket", 4);

                if (timer >= 1f)
                {
                    klon = Instantiate(mermi, namluucu.position, namlu.rotation);
                    klon.GetComponent<Rigidbody>().AddForce(klon.forward * 500f);
                    timer = 0f;
                }
            }
            //Olme
            else if (M_medic_can <= 0)
            {
                moveSpeed = 0f;
                anim.SetInteger("Hareket", 3);
                StartCoroutine(DestroyAfterAnimation());
            }
            //Devam
            else if (mesafe > 3 && anim.GetInteger("Hareket") == 4)
            {
                anim.SetInteger("Hareket", 5);
            }
            else
            {
                moveSpeed = 0f;
                anim.SetInteger("Hareket", 1);
            }
        }
        if (nesne.gameObject.tag == "Siper3")
        {
            if (M_siperkontrol3 == 1)
            {
                SiperKomutuCalistir(nesne.gameObject);
            }
            else if (mesafe <= 3)
            {
                if (enYakinObje != null)
                {
                    DusmanBakma = enYakinObje.transform;
                    transform.LookAt(DusmanBakma);
                }

                moveSpeed = 0f;
                anim.SetInteger("Hareket", 4);

                if (timer >= 1f)
                {
                    klon = Instantiate(mermi, namluucu.position, namlu.rotation);
                    klon.GetComponent<Rigidbody>().AddForce(klon.forward * 500f);
                    timer = 0f;
                }
            }
            //Olme
            else if (M_medic_can <= 0)
            {
                moveSpeed = 0f;
                anim.SetInteger("Hareket", 3);
                StartCoroutine(DestroyAfterAnimation());
            }
            //Devam
            else if (mesafe > 3 && anim.GetInteger("Hareket") == 4)
            {
                anim.SetInteger("Hareket", 5);
            }
            else
            {
                moveSpeed = 0f;
                anim.SetInteger("Hareket", 1);
            }
        }
    }
    public void OnTriggerExit(Collider nesne)
    {
        //SiperCikis
        if (nesne.gameObject.tag == "Siper1")
        {
            anim.SetInteger("Hareket", 2);
            moveSpeed = 10f;
            Sayac1.sayac1 -= 1;
        }
        if (nesne.gameObject.tag == "Siper2")
        {
            anim.SetInteger("Hareket", 2);
            moveSpeed = 10f;
            Sayac2.sayac2 -= 1;
        }
        if (nesne.gameObject.tag == "Siper3")
        {
            anim.SetInteger("Hareket", 2);
            moveSpeed = 10f;
            Sayac3.sayac3 -= 1;
        }
    }
    private float KirmiziTakim()
    {
        float minDistance = float.MaxValue;
        GameObject[] dusman = GameObject.FindGameObjectsWithTag(targetTag);

        foreach (GameObject obj in dusman)
        {
            float distance = Vector3.Distance(transform.position, obj.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
            }
        }

        return minDistance;
    }
    public void Askencan(float mermi)
    {
        M_medic_can -= mermi;
    }
    public void SiperKomutuCalistir(GameObject siperObjesi)
    {
        moveSpeed = 10f;
        anim.SetInteger("Hareket", 2);
    }
    IEnumerator DestroyAfterAnimation()
    {
        gameObject.tag = "Untagged";
        targetTag = "Untagged";
        AudioSource.PlayClipAtPoint(Olme_Sesi, transform.position);
        //Yok Olma
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}