using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventQueue : MonoBehaviour
{
    [SerializeField]
    private List<EventData> eventList = new List<EventData>();

    public Queue<EventData> eventQueue;

    private void OnEnable()
    {
        eventQueue = new Queue<EventData>(eventList);
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
