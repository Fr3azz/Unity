using System.Collections;
using UnityEngine;

public class lab03_zad3 : MonoBehaviour
{
    public float speed;
    float poczx;
    float endx;
    float poczz;
    float endz;
    int a = 0;
    int b = 0;

    void Start()
    {
        poczx = transform.position.x;
        endx = transform.position.x + 10.0f;
        poczz = transform.position.z;
        endz = transform.position.z + 10.0f;
    }


    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (transform.position.x > endx && a == 0)
        {
            transform.Rotate(0, -90, 0, Space.World);
            a = 1;
        }
        if (transform.position.x < poczx && a == 1) 
        {
            transform.Rotate(0, -90, 0, Space.World);
            a = 0;
        }
        if (transform.position.z > endz && b == 0)
        {
            transform.Rotate(0, -90, 0, Space.World);
            b = 1;
        }
        if (transform.position.z < poczz && b == 1)
        {
            transform.Rotate(0, -90, 0, Space.World);
            b = 0;
        }
    }
}

