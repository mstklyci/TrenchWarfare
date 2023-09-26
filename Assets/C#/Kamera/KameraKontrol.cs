 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public float minX;
    private float hareketHizi = 50f;

    private void Update()
    {
        float hareketMiktari = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            hareketMiktari = -hareketHizi * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            hareketMiktari = hareketHizi * Time.deltaTime;
        }

        float yeniX = transform.position.x + hareketMiktari;

        yeniX = Mathf.Clamp(yeniX, -minX, minX);

        transform.position = new Vector3(yeniX, transform.position.y, transform.position.z);
    }
}