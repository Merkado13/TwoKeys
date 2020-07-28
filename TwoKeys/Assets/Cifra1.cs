using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cifra1 : MonoBehaviour
{

    //Quaternion targetAngle_36 = Quaternion.Euler(transform.rotation.x,36,0);
    // Start is called before the first frame update
    // Quaternion rotation = Quaternion.LookRotation(transform.rotation);

    GameObject cifra2;
    GameObject cifra3;
    GameObject cifra4;
    int counter;
    int counterCifra2;
    int counterCifra3;
    int counterCifra4;

    private float currentAngleCifra1;
    private float angleStep = -36.0f;
    private bool isRotating = false;

    public SharedKeyData keyData;

    void Start()
    {
        cifra2 = GameObject.Find("Cifra 2");
        cifra3 = GameObject.Find("Cifra 3");
        cifra4 = GameObject.Find("Cifra 4");

        counter = 0;
        counterCifra2 = 0;
        counterCifra3 = 0;
        counterCifra4 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 9999)
        {
            //Se quedaria parado y empezaria el postgame
        }
        else
        {

            
        }
    }

    public void ShiftCounter()
    {
        currentAngleCifra1 += angleStep * keyData.incrPulsations;
        if (!isRotating)
        {
            StartCoroutine(RotateSlerp(this.gameObject, 1, 3, keyData.incrPulsations));
        }
        counter += keyData.incrPulsations;
        counterCifra2 += keyData.incrPulsations;
        counterCifra3 += keyData.incrPulsations;
        counterCifra4 += keyData.incrPulsations;

        if (counterCifra2 == 10)
        {
            //cifra2.transform.rotation = Quaternion.Slerp(cifra2.transform.rotation, cifra2.transform.rotation * Quaternion.Euler(0, -36, 0), 1f);
            StartCoroutine(RotateSlerp(cifra2, 2, 3, keyData.incrPulsations));
            counterCifra2 = 0;
        }
        if (counterCifra3 == 100)
        {
            //cifra3.transform.rotation = Quaternion.Slerp(cifra3.transform.rotation, cifra3.transform.rotation * Quaternion.Euler(0, -36, 0), 1f);
            StartCoroutine(RotateSlerp(cifra3, 2, 3, keyData.incrPulsations));
            counterCifra3 = 0;
        }
        if (counterCifra4 == 1000)
        {
            //cifra4.transform.rotation = Quaternion.Slerp(cifra4.transform.rotation, cifra4.transform.rotation * Quaternion.Euler(0, -36, 0), 1f);
            StartCoroutine(RotateSlerp(cifra4, 2, 3, keyData.incrPulsations));
            counterCifra4 = 0;
        }
    }

    private IEnumerator RotateSlerp(GameObject cifra, int id, float speed, int amount)
    {
        Quaternion rotation = cifra.transform.rotation;
        float delta = 0.0f;
        float targetAngle = angleStep * amount;

        if (id == 1) {

            targetAngle = currentAngleCifra1;
            isRotating = true;
        }

        while (delta <= 1.0f)
        {
            cifra.transform.rotation = Quaternion.Slerp(rotation, rotation * Quaternion.Euler(0, targetAngle, 0), delta);
            delta += speed * Time.deltaTime;
            if (id == 1)
            {

                delta *= (targetAngle / currentAngleCifra1);
                targetAngle = currentAngleCifra1;

            }
            yield return null;
        }

        cifra.transform.rotation = Quaternion.Slerp(rotation, rotation * Quaternion.Euler(0, targetAngle, 0), 1.0f);


        if (id == 1)
        {
            currentAngleCifra1 = 0.0f;
            isRotating = false;
        }
    }
}
