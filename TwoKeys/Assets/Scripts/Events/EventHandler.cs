using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    
    [SerializeField]
    private EventQueue eventQueue;

    private EventQueue.PulsationEvent currentEvent;

    private GameController gameController; 
    private void Awake()
    {
        gameController = GetComponent<GameController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        currentEvent = eventQueue.eventQueue.Dequeue();

    }

    // Update is called once per frame
    void Update()
    {
        if (currentEvent != null) { 
            if (gameController.numPulsations >= currentEvent.numPulsations)
            {
                currentEvent.pulsationEvent.Invoke();
                if (eventQueue.eventQueue.Count > 0)
                    currentEvent = eventQueue.eventQueue.Dequeue();
                else
                    currentEvent = null;
            }
        }
    }
}
