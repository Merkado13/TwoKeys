using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAudioPlayer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudioFrom(AudioClip[] set, AudioSource source)
    {
        AudioClip ac = GetRandomAudioFromSet(set);
        source.clip = ac;
        source.Play();
    }

    private AudioClip GetRandomAudioFromSet(AudioClip[] set)
    {
        return set[Random.Range(0, set.Length)];
    }
}
