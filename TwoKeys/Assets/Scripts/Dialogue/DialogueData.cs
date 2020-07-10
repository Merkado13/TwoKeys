using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue")]
public class DialogueData : ScriptableObject
{
    [TextArea(7, 7)]
    public string[] texts;
}

