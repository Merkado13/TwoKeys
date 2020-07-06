using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI counterText;

    [SerializeField]
    private SharedKeyData keyData;

    [SerializeField]
    private GameObject popUpTextPrefab;

    [SerializeField]
    private Transform targetPopUpText;

    private const string counterInit = "000000";

    // Start is called before the first frame update
    void Start()
    {
        counterText.text = "000000";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCounterTextToNumber(int number)
    {
        if (number != 0) {
            string numberAppend = number.ToString();
            string counterRaw = counterInit + numberAppend;
            string finalText = counterRaw.Substring(numberAppend.Length);
            counterText.text = finalText;
            if(popUpTextPrefab)
                PopUpIncrText();
        }

    }

    private void PopUpIncrText()
    {
        GameObject popUpText = Instantiate(popUpTextPrefab, targetPopUpText.transform.localPosition, Quaternion.identity, transform);
        PopUpText popUp = popUpText.GetComponent<PopUpText>();
        if(keyData.incrPulsations > 0)
        {
            popUp.Init(Vector3.up, "+" + keyData.incrPulsations.ToString());
        }
        else
        {
            popUp.Init(-Vector3.up, keyData.incrPulsations.ToString());
        }
        
    }
}
