using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voiture : MonoBehaviour
{
    [SerializeField] private float VitesseRotation = 50f;
    [SerializeField] private float VitesseMax = 150f;
    [SerializeField] private float VitesseAcceleration = 25f;
    [SerializeField] private float VitesseRotationMax = 100f;
    

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * VitesseAcceleration;
        translation = Mathf.Clamp(translation, VitesseMax * -1, VitesseMax);

        // rotation de la voiture en fonction de la vitesse
        float rotation = Input.GetAxis("Horizontal") * translation * VitesseRotation;
        rotation = Mathf.Clamp(rotation, -VitesseRotationMax, VitesseRotationMax);
        
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }

    public float GetVitesseRotation()
    {
        return VitesseRotation;
    }
}
