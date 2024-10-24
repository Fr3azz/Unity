using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEngine;

public class RandomCubesGenerator : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    public int ile;
    int objectCounter = 0;
    // obiekt do generowania
    public GameObject block;
    Collider m_Collider;
    Vector3 m_Min, m_Max;
    int x1, x2, z1, z2;
    void Start()
    {
        m_Collider = GetComponent<Collider>();
        m_Min = m_Collider.bounds.min;
        m_Max = m_Collider.bounds.max;
        x1 = (int)m_Min[0];
        x2 = (int)m_Max[0];
        x2 = x2 * 2;
  
        z1 = (int)m_Min[2];
        z2 = (int)m_Max[2];
        z2 = z2 * 2;


        List<int> pozycje_x = new List<int>(Enumerable.Range(x1, x2).OrderBy(x => Guid.NewGuid()).Take(ile));
        List<int> pozycje_z = new List<int>(Enumerable.Range(z1, z2).OrderBy(x => Guid.NewGuid()).Take(ile));

        for (int i = 0; i < ile; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywo³ano coroutine");
        foreach (Vector3 pos in positions)
        {
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}


