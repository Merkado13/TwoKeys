using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Event", menuName = "Event")]
public class EventData : ScriptableObject
{
    public int numPulsations;
    public DialogueData dialogue;
    public UnityEvent pulsationEvent;

    public void Perform()
    {
        GameController.current.textSystem.SetDialogue(dialogue);
        GameController.current.textSystem.PrintNextText();
        pulsationEvent.Invoke();
    }
}
