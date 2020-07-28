using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextSystem : MonoBehaviour
{
   
    private TMP_Animated textBox;

    [SerializeField]
    private GameObject tmpPrefab;

    private DialogueData currentDialogue;
    private int currentIndex = 0;

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

    public void SetDialogue(DialogueData dialogue)
    {
        textBox = GameController.current.textBox;
        currentDialogue = dialogue;
        currentIndex = 0;
    }

    public void PrintNextText()
    {    
        if(currentIndex < currentDialogue.texts.Length)
            textBox.ReadText(currentDialogue.texts[currentIndex++]);
    }

    public void Hola()
    {
        Debug.Log("jhjh");
    }

}
