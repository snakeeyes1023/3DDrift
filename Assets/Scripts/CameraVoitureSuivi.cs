using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script qui permet de suivre une voiture avec la caméra
/// </summary>
public class CameraVoitureSuivi : MonoBehaviour
{
    [SerializeField] private Transform Voiture;
    [SerializeField] private Vector3 Offset = new Vector3(0, 5, -10);
    [SerializeField] private float DelaiSuivi = 0.1f;
    private Vector3 Velocite = Vector3.zero;

    private void LateUpdate()
    {
        Vector3 targetPosition = Voiture.TransformPoint(Offset);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref Velocite, DelaiSuivi);
        transform.LookAt(Voiture);
    }
}
