using UnityEngine;

public class randomitem : MonoBehaviour
{
    [SerializeField] string[] Items = new string[] {};

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) PrintRandomItem();
        if (Input.GetKeyDown(KeyCode.Escape)) PrintAllItems();
    }
    private void PrintRandomItem()
    {
        //printen van 1 random item.
        
        Debug.Log(Items[Random.Range(0, 9)]);
        

    }
    private void PrintAllItems()
    {
        //Printen van alle items
        for (int i = 0; i < Items.Length; i++)
        {
            Debug.Log(Items[i]);
        }
    }
}
