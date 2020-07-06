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
    [SerializeField]
    private CameraShaking cameraShaking;
    [SerializeField]
    private float shakeDuration = 1.0f;
    [SerializeField]
    private float shakeMagnitude = 1.0f;

    [SerializeField]
    private GameObject model;

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
            model.transform.Translate(transform.forward * offsetDisplacement, Space.World);
            audioPlayer.PlayAudioFrom(GameController.current.currentAudioSet.audiosKeyDown, audioSources[(int)KeyState.DOWN]);
            particleHandler.PlayParticleSystem();
            StartCoroutine(cameraShaking.Shake(shakeDuration, shakeMagnitude));
        }
        else if (Input.GetKeyUp(key))
        {
            model.transform.Translate(-transform.forward * offsetDisplacement, Space.World);
            audioPlayer.PlayAudioFrom(GameController.current.currentAudioSet.audiosKeyUp, audioSources[(int)KeyState.UP]);
        }
    }
}
