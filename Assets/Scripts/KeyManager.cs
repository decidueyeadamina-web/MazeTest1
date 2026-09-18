using UnityEngine;

public class KeyManager : MonoBehaviour
{   
    // key UI
    public GameObject key1UION;
    public GameObject key2UION;
    public GameObject key3UION;
    public GameObject key4UION;
    public GameObject key5UION;
    public GameObject key6UION;

    //distance floats

    public float canOpen = 1f;

    //transforms

    public Transform Player;
    public Transform CastleDoor1;
    public Transform CastleDoor2;
    public Transform CastleDoor3;
    public Transform FinalDoor4;

    //destroyable doors

    public GameObject Room3Door;
    public GameObject Room4Door;
    public GameObject Room5Door;
    public GameObject ExitCastleDoor;

    //bools test

    public bool hasKey1;

    // bc u will forget: keys 1-3 open the win condition door at the start
    //keys 1-3 are their own deal

    // key 4 in room 2 opens door in room 4, key 5 in room 3 opens door to room 5, key 6 in room 4 opens door to room 3
    //2-4, 3-5. 4-3
    // Update is called once per frame
    void Update()
    {   
       // if (key1UION.SetActive(true))
       // {
       //     hasKey1 = true;
       // }
        
        float distance1 = Vector3.Distance(Player.position, FinalDoor4.position);
        
        if (hasKey1 == true && distance1 <= canOpen)
        {
            Destroy(ExitCastleDoor);
        }
        
        //float distance2 = Vector3.Distance(Player.position, CastleDoor1.position);
        
        //if (key4Has.SetActive(true) && distance2 <= canOpen)
        //{
        //    Destroy(Room3Door);
        //}
        //float distance3 = Vector3.Distance(Player.position, CastleDoor2.position);
        
        //if (key5Has.SetActive(true) && distance3 <= canOpen)
        //{
        //    Destroy(Room4Door);
        //}
        
        //float distance4 = Vector3.Distance(Player.position, CastleDoor3.position);
        
        //if (key6Has.SetActive(true) && distance4 <= canOpen)
        //{
        //    Destroy(Room5Door);
        //}
    }
}
