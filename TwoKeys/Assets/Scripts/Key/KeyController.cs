﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    private Vector3 originalPos;

    [SerializeField]
    private AudioSource[] audioSources;
    [SerializeField]
    private CameraShaking cameraShaking;
    [SerializeField]
    private SharedKeyData keyData;

    [SerializeField]
    private GameObject model;

    private void Awake()
    {
        audioPlayer = GetComponent<KeyAudioPlayer>();
        particleHandler = GetComponent<KeyParticleHandler>();
        originalPos = transform.position;
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
            model.transform.position = originalPos + transform.forward * offsetDisplacement;
            audioPlayer.PlayAudioFrom(GameController.current.currentAudioSet.audiosKeyDown, audioSources[(int)KeyState.DOWN]);
            particleHandler.PlayParticleSystem();
            StartCoroutine(cameraShaking.Shake(keyData.shakeDuration, keyData.shakeMagnitude));
        }
        else if (Input.GetKeyUp(key))
        {
            model.transform.position = originalPos;
            audioPlayer.PlayAudioFrom(GameController.current.currentAudioSet.audiosKeyUp, audioSources[(int)KeyState.UP]);
            GameController.current.ShiftNumPulsationsByAmount(keyData.incrPulsations);
        }
    }
}
