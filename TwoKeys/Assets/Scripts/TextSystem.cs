using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextSystem : MonoBehaviour
{
   
    private TMP_Animated textBox;

    [SerializeField]
    private GameObject tmpPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject tmpObject = Instantiate(tmpPrefab);
        //textBox = tmpObject.GetComponent<TMP_Animated>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintText(string text)
    {
        textBox = GameController.current.textBox;
        textBox.ReadText(text);
    }

    public void Hola()
    {
        Debug.Log("jhjh");
    }

}
