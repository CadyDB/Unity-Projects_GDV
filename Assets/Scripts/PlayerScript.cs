using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PlayerScript : MonoBehaviour
{
    public string itemType = "Coin";
    public int value = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Les 4.1: tag checking
        {
            //Haal het script van de player op!
            PlayerScript player = other.GetComponent<PlayerScript>();

            // Switch uit Les 5.1 + collision uit Les 4.2
            
                
           
        }
    }
}
