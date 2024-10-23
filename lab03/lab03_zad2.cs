using System.Collections;
using UnityEngine;

public class lab03_zad2 : MonoBehaviour
{
    public float speed;
    float pocz;
    float end;

    void Start()
    {
        pocz = transform.position.x;
        end = transform.position.x + 10.0f;
    }


    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (transform.position.x > end)
        {
            speed = speed * -1;
        }
        if (transform.position.x < pocz)
        {
            speed = speed * -1;
        }
    }
}

