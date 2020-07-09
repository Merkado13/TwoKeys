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

    void Start()
    {
        cifra2 = GameObject.Find("Cifra 2");
        cifra3 = GameObject.Find("Cifra 3");
        cifra4 = GameObject.Find("Cifra 4");

        counter = 0;
        counterCifra2=0;
        counterCifra3=0;
        counterCifra4=0;
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
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                // rotation *= Quaternion.Euler(0, 36, 0);
                // transform.rotation = Quaternion.Slerp(transform.rotation,transform.rotation*Quaternion.Euler(0, -36, 0), 1f);
                transform.rotation = Quaternion.Slerp(transform.rotation, transform.rotation * Quaternion.Euler(0, -36, 0), 1f);
                counter++;
                counterCifra2++;
                counterCifra3++;
                counterCifra4++;
            }
            if (counterCifra2 == 10)
            {
                cifra2.transform.rotation = Quaternion.Slerp(cifra2.transform.rotation, cifra2.transform.rotation * Quaternion.Euler(0, -36, 0), 1f);
                counterCifra2 = 0;
            }
            if (counterCifra3 == 100)
            {
                cifra3.transform.rotation = Quaternion.Slerp(cifra3.transform.rotation, cifra3.transform.rotation * Quaternion.Euler(0, -36, 0), 1f);
                counterCifra3 = 0;
            }
            if (counterCifra4 == 1000)
            {
                cifra4.transform.rotation = Quaternion.Slerp(cifra4.transform.rotation, cifra4.transform.rotation * Quaternion.Euler(0, -36, 0), 1f);
                counterCifra4 = 0;
            }
        }
    }
}
