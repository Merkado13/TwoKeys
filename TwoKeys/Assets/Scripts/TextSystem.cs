using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextSystem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintText(string text)
    {
        StartCoroutine(ParseText(text));
    }

    private IEnumerator ParseText(string text)
    {
        textBox.text = text;
        yield return null;
    }
}
