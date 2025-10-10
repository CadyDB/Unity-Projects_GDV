using UnityEngine;

public class TriggerIt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Peekaboo! Je bent geraakt!");
        other.attachedRigidbody.isKinematic = false;
    }
}
