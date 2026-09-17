using UnityEngine;

public class ItemPickup : MonoBehaviour
{   
    public Transform Player;
    public Transform Key;
    public GameObject DoorKey;

    public float closeEnough = 1f;

    public bool keyCollected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        keyCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Player.position, Key.position);

        if (distance <= closeEnough)
        {
            ItemGrab();
            keyCollected = true;
        }

        if (keyCollected)
        {
            Debug.Log("UI for the collection should show up");
        }
    }

    void ItemGrab()
    {
        Destroy(DoorKey);
    }
}
