using UnityEngine;

public class ItemPickup : MonoBehaviour
{   
    //all transforms
    public Transform Player;
    public Transform Key1Locator;
    public Transform Key2Locator;
    public Transform Key3Locator;
    public Transform Key4Locator;
    public Transform Key5Locator;
    public Transform Key6Locator;

    // all phyisical keys to destroy - Game objects
    public GameObject DoorKey1;
    public GameObject DoorKey2;
    public GameObject DoorKey3;
    public GameObject DoorKey4;
    public GameObject DoorKey5;
    public GameObject DoorKey6;
    
    // all key ui to toggle
    public GameObject Key1UI;
    public GameObject Key2UI;
    public GameObject Key3UI;
    public GameObject Key4UI;
    public GameObject Key5UI;
    public GameObject Key6UI;

    // float for distance check
    public float closeEnough = 1f;
    public float closeEnoughDoor = 5f;

    //collection bool for UI on and off + door openability
    public bool Key1Collected;
    public bool Key2Collected;
    public bool Key3Collected;
    public bool Key4Collected;
    public bool Key5Collected;
    public bool Key6Collected;

    //door transforms
    public Transform CastleDoor1;
    public Transform CastleDoor2;
    public Transform CastleDoor3;
    public Transform FinalDoor4;

    //destroyable doors

    public GameObject Room3Door;
    public GameObject Room4Door;
    public GameObject Room5Door;
    public GameObject ExitCastleDoor;

    //sound controller

    public AudioClip keyPickUpSFX;
    public AudioSource sourceAudio;

    public bool hasOpenedDoor1;
    public bool hasOpenedDoor2;
    public bool hasOpenedDoor3;
    public bool hasOpenedDoor4;

    //item slot go's
    public GameObject Key1Slot;
    public GameObject Key2Slot;
    public GameObject Key3Slot;
    public GameObject Key4Slot;
    public GameObject Key5Slot;
    public GameObject Key6Slot;

    // bc u will forget: keys 1-3 open the win condition door at the start
    //keys 1-3 are their own deal

    // key 4 in room 2 opens door in room 4, key 5 in room 3 opens door to room 5, key 6 in room 4 opens door to room 3
    //2-4, 3-5. 4-3
    void Start()
    {   
        //player has no keys (UI)
        Key1UI.SetActive(false);
        Key2UI.SetActive(false);
        Key3UI.SetActive(false);
        Key4UI.SetActive(false);
        Key5UI.SetActive(false);
        Key6UI.SetActive(false);

        //player has no keys (bool)
        Key1Collected = false;
        Key2Collected = false;
        Key3Collected = false;
        Key4Collected = false;
        Key5Collected = false;
        Key6Collected = false;

        //itemSlotTaken
        Key1Slot.SetActive(true);
        Key2Slot.SetActive(true);
        Key3Slot.SetActive(true);
        Key4Slot.SetActive(true);
        Key5Slot.SetActive(true);
        Key6Slot.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {   
        //each key distance uses letters
        //Grab Key1
        float distanceA = Vector3.Distance(Player.position, Key1Locator.position);

        if (distanceA <= closeEnough)
        {
            ItemGrab1();
            Key1Collected = true;
            Key1Slot.SetActive(false);
            
        }

        //Grab Key2
        float distanceB = Vector3.Distance(Player.position, Key2Locator.position);

        if (distanceB <= closeEnough)
        {
            ItemGrab2();
            Key2Collected = true;
            Key2Slot.SetActive(false);
        }

        //Grab Key3
        float distanceC = Vector3.Distance(Player.position, Key3Locator.position);

        if (distanceC <= closeEnough)
        {
            ItemGrab3();
            Key3Collected = true;
            Key3Slot.SetActive(false);
        }

        //Grab Key4
        float distanceD = Vector3.Distance(Player.position, Key4Locator.position);

        if (distanceD <= closeEnough)
        {
            ItemGrab4();
            Key4Collected = true;
            Key4Slot.SetActive(false);
        }

        //Grab Key5
        float distanceE = Vector3.Distance(Player.position, Key5Locator.position);

        if (distanceE <= closeEnough)
        {
            ItemGrab5();
            Key5Collected = true;
            Key5Slot.SetActive(false);
        }

        //Grab Key6
        float distanceF = Vector3.Distance(Player.position, Key6Locator.position);

        if (distanceF <= closeEnough)
        {
            ItemGrab6();
            Key6Collected = true;
            Key6Slot.SetActive(false);
        }

        //door checks, use numbers for distance
        
        //main door
        float distance1 = Vector3.Distance(Player.position, FinalDoor4.position);
        
        if (Key1Collected == true && Key2Collected == true && Key3Collected == true && distance1 <= closeEnoughDoor && hasOpenedDoor4 == false)
        {
            ExitCastleDoor.SetActive(false);
        }
        
        //door 1 in room 3
        float distance2 = Vector3.Distance(Player.position, CastleDoor1.position);
        
        if (Key4Collected == true && distance2 <= closeEnoughDoor && hasOpenedDoor1 == false)
        {
            Room3Door.SetActive(false);
        }
        
        //door 2 in room 4
        float distance3 = Vector3.Distance(Player.position, CastleDoor2.position);
        
        if (Key5Collected == true && distance3 <= closeEnoughDoor && hasOpenedDoor2 == false)
        {
            Room4Door.SetActive(false);
        }
        
        //door 3 in room 5
        float distance4 = Vector3.Distance(Player.position, CastleDoor3.position);
        
        if (Key6Collected == true && distance4 <= closeEnoughDoor && hasOpenedDoor3 == false)
        {
            Room5Door.SetActive(false);
        }
    }

    //grabbing each key sets certain UI and bools off its matched by number u get it
    void ItemGrab1()
    {
        DoorKey1.SetActive(false);
        Key1UI.SetActive(true);
        //play audio
        sourceAudio = GetComponent<AudioSource>();
        sourceAudio.PlayOneShot(keyPickUpSFX);
    }
    void ItemGrab2()
    {
        DoorKey2.SetActive(false);
        Key2UI.SetActive(true);
        //play audio
        sourceAudio = GetComponent<AudioSource>();
        sourceAudio.PlayOneShot(keyPickUpSFX);

    }
    void ItemGrab3()
    {
        DoorKey3.SetActive(false);
        Key3UI.SetActive(true);
        //play audio
        sourceAudio = GetComponent<AudioSource>();
        sourceAudio.PlayOneShot(keyPickUpSFX);

    }
    void ItemGrab4()
    {
        DoorKey4.SetActive(false);
        Key4UI.SetActive(true);
        //play audio
        sourceAudio = GetComponent<AudioSource>();
        sourceAudio.PlayOneShot(keyPickUpSFX);

    }
    void ItemGrab5()
    {
        DoorKey5.SetActive(false);
        Key5UI.SetActive(true);
        //play audio
        sourceAudio = GetComponent<AudioSource>();
        sourceAudio.PlayOneShot(keyPickUpSFX);

    }
    void ItemGrab6()
    {
        DoorKey6.SetActive(false);
        Key6UI.SetActive(true);
        //play audio
        sourceAudio = GetComponent<AudioSource>();
        sourceAudio.PlayOneShot(keyPickUpSFX);

    }
}
