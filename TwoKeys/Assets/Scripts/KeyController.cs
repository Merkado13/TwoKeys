using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum KeyState {UP, DOWN}

public class KeyController : MonoBehaviour
{
    [SerializeField]
    private KeyCode key;
    [SerializeField]
    private float offsetDisplacement = 1.0f;

    private KeyAudioPlayer audioPlayer;
    private KeyParticleHandler particleHandler;

    [SerializeField]
    private AudioSource[] audioSources;

    private void Awake()
    {
        audioPlayer = GetComponent<KeyAudioPlayer>();
        particleHandler = GetComponent<KeyParticleHandler>();
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
            audioPlayer.PlayAudioFrom(GameController.current.currentAudioSet.audiosKeyDown, audioSources[(int)KeyState.DOWN]);
            particleHandler.PlayParticleSystem();
        }
        else if (Input.GetKeyUp(key))
        {
            transform.Translate(-transform.forward * offsetDisplacement, Space.World);
            audioPlayer.PlayAudioFrom(GameController.current.currentAudioSet.audiosKeyUp, audioSources[(int)KeyState.UP]);
        }
    }
}
