using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public Transform player;
    public Transform cam;
    public float sensitivity = 200f;

    // Zmienna do �ledzenia obrotu wok� osi X (g�ra-d�)
    private float xRotation = 0f;

    void Start()
    {
        // Zablokowanie kursora na �rodku ekranu oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Pobieramy warto�ci dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Wykonujemy rotacj� wok� osi Y (obracanie w lewo i prawo)
        player.Rotate(Vector3.up * mouseXMove);

        // Aktualizujemy rotacj� wok� osi X (g�ra-d�)
        xRotation -= mouseYMove;

        // Ograniczamy rotacj� w zakresie od -90 do +90 stopni
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Ustawiamy rotacj� wok� osi X
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
