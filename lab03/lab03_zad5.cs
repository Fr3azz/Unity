using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class lab03_zad5 : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    List<Vector3> positions = new List<Vector3>();
    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        List<int> pozycje_x = new List<int>(Enumerable.Range(-4, 10).OrderBy(x => Guid.NewGuid()).Take(10));
        List<int> pozycje_z = new List<int>(Enumerable.Range(-4, 10).OrderBy(x => Guid.NewGuid()).Take(10));
        for (int i = 0; i < 10; i++)
        {
            // Instantiate at position (0, 0, 0) and zero rotation.
            Instantiate(myPrefab, new Vector3(pozycje_x[i], 1, pozycje_z[i]), Quaternion.identity);
        }
    }
}