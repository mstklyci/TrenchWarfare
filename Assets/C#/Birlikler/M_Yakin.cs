    using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using static Unity.Burst.Intrinsics.Arm;

public class M_Yakin : MonoBehaviour
{
    //SayisalDeger
    public float yon;
    private float moveSpeed = 12f;
    private float mesafe = 1f;
    private float M_Yakin_can = 20f;

    //Ses
    public AudioClip Silah_Sesi;
    public AudioClip Olme_Sesi;

    //Olme Kontrol
    private bool olme = false;

    //Süre
    private float timer = 0f;

    //Taglar
    public string targetTag = "";

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
        if (M_Yakin_can <= 0 && anim.GetInteger("Hareket") == 0
            || M_Yakin_can <= 0 && anim.GetInteger("Hareket") == 2
            || M_Yakin_can <= 0 && anim.GetInteger("Hareket") == 7)
        {
            moveSpeed = 0f;
            anim.SetInteger("Hareket", 8);
            StartCoroutine(DestroyAfterAnimation());
        }
        //DusmanaGitme
        if (mesafe <= 20)
        {
            if (enYakinObje != null)
            {
                DusmanBakma = enYakinObje.transform;
                transform.LookAt(DusmanBakma);
            }
        }       
        //Ates
        if (mesafe <= 1)
        {            
            moveSpeed = 0f;
            anim.SetInteger("Hareket", 6);
            if (timer >= 1f)
            {
                AudioSource.PlayClipAtPoint(Silah_Sesi, transform.position);
                timer = 0f;
            }      
            if (M_Yakin_can <= 0)
            {
                moveSpeed = 0f;
                anim.SetInteger("Hareket", 9);
                StartCoroutine(DestroyAfterAnimation());
            }
        }
        else if (mesafe > 1 && anim.GetInteger("Hareket") == 6)
        {
            moveSpeed = 13f;
            anim.SetInteger("Hareket", 7);
        }
    }
    public void OnTriggerEnter(Collider nesne)
    {
        //SiperGÝRÝS
        if (nesne.gameObject.tag == "Siper1")
        {
            anim.SetInteger("Hareket", 2);
            moveSpeed = 12f;
            if (timer >= 1f)
            {
                Sayac1.sayac1 -= 1;
                timer = 0f;
            }            
        }
        if (nesne.gameObject.tag == "Siper2")
        {
            anim.SetInteger("Hareket", 2);
            moveSpeed = 12f;
            if (timer >= 1f)
            {
                Sayac2.sayac2 -= 1;
                timer = 0f;
            }
        }
        if (nesne.gameObject.tag == "Siper3")
        {
            anim.SetInteger("Hareket", 2);
            moveSpeed = 12f;
            if (timer >= 1f)
            {
                Sayac3.sayac3 -= 1;
                timer = 0f;
            }
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
        M_Yakin_can -= mermi;
    }
    public void SiperKomutuCalistir(GameObject siperObjesi)
    {
        moveSpeed = 13f;
        anim.SetInteger("Hareket", 2);
    }
    IEnumerator DestroyAfterAnimation()
    {
        if (!olme)
        {
            olme = true;

            gameObject.tag = "Untagged";
            targetTag = "Untagged";
            AudioSource.PlayClipAtPoint(Olme_Sesi, transform.position);
            //Yok Olma
            yield return new WaitForSeconds(5f);
            Destroy(gameObject);
        }
    }
}