using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class GameController : MonoBehaviour
{

    public static GameController current;
    public AudioSet currentAudioSet;
    public TMP_Animated textBox;

    [SerializeField]
    private AudioSet[] audioSets;

    [SerializeField]
    private GUIController controller;

    public int numPulsations;

    private void Awake()
    {
        current = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentAudioSet = audioSets[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShiftNumPulsationsByAmount(int amount)
    {
        numPulsations += amount;
        Mathf.Clamp(numPulsations, 0, 1000000);
        controller.SetCounterTo(numPulsations);
    }
}
