using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField]
    private KeyCode key;
    [SerializeField]
    private float offsetDisplacement = 1.0f;

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            transform.Translate(transform.forward * offsetDisplacement, Space.World);
        }
        else if (Input.GetKeyUp(key))
        {
            transform.Translate(-transform.forward * offsetDisplacement, Space.World);

        }
    }
}
