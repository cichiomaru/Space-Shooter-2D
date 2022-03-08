using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CircleCollider2D))]
public class TriggerEvent : MonoBehaviour
{
    public string targetTag;

    public UnityEvent OnTrigger;
    public UnityEvent<GameObject> OnTriggerWithGameobject;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == targetTag) {
            OnTrigger?.Invoke();
            OnTriggerWithGameobject?.Invoke(collision.gameObject);
        }
    }
}
