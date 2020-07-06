using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController current;
    public AudioSet currentAudioSet;

    [SerializeField]
    private AudioSet[] audioSets;

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
}
