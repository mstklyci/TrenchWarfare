using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalVS_Camera : MonoBehaviour
{
    private float minX = 55f;
    private float hareketHizi = 50f;

    private void Update()
    {
        float hareketMiktari = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            hareketMiktari = -hareketHizi * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            hareketMiktari = hareketHizi * Time.deltaTime;
        }

        float yeniX = transform.position.x + hareketMiktari;

        yeniX = Mathf.Clamp(yeniX, -minX, minX);

        transform.position = new Vector3(yeniX, transform.position.y, transform.position.z);
    }
}