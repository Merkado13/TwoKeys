using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour
{

    [SerializeField]
    private Counter counter;

    [SerializeField]
    private Cifra1 cifras;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCounterTo(int amount)
    {
        counter.ChangeCounterTextToNumber(amount);
        cifras.ShiftCounter();
    }
}
