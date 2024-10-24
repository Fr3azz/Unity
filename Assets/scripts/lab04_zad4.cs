using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public Transform player;
    public Transform cam;
    public float sensitivity = 200f;

    // Zmienna do œledzenia obrotu wokó³ osi X (góra-dó³)
    private float xRotation = 0f;

    void Start()
    {
        // Zablokowanie kursora na œrodku ekranu oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Pobieramy wartoœci dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Wykonujemy rotacjê wokó³ osi Y (obracanie w lewo i prawo)
        player.Rotate(Vector3.up * mouseXMove);

        // Aktualizujemy rotacjê wokó³ osi X (góra-dó³)
        xRotation -= mouseYMove;

        // Ograniczamy rotacjê w zakresie od -90 do +90 stopni
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Ustawiamy rotacjê wokó³ osi X
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
