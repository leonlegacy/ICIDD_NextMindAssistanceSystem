using UnityEngine;
using UnityEngine.Events;

public class buttonTriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            triggerEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            triggerEvent.Invoke();
    }
}
