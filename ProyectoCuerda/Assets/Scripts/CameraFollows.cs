using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    public Transform target; // El jugador
    public Vector3 offset; // Desplazamiento de la c�mara
    void LateUpdate()
    {
        // Calcula la nueva posici�n de la c�mara
        Vector3 desiredPosition = target.position + offset;
        // Suaviza el movimiento de la c�mara
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * 5);
    }
}
