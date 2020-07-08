using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventQueue : MonoBehaviour
{
    [System.Serializable]
    public class PulsationEvent
    {
        public int numPulsations;
        public UnityEvent pulsationEvent;
    }

    [SerializeField]
    private List<PulsationEvent> eventList = new List<PulsationEvent>();

    public Queue<PulsationEvent> eventQueue;

    private void OnEnable()
    {
        eventQueue = new Queue<PulsationEvent>(eventList);
    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
