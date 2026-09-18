using UnityEngine;

public class playSFX : MonoBehaviour
{   
    //hi again! This is also a script I made in a games tech class a year ago.
    // I can tell you what these mean generally and I changed things around from what I originally used for this assignment

    public AudioClip breakSound;
    public AudioSource groundAudio;

    //these are some parts I actually don't get a lot! I know Audio clip is what I use as a place on the script to link the .wav file
    // AudioSource is how I attach that component to this script

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //at first, the sounds had to be automatic so everything was placed under update, which I changed here.
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            groundAudio = GetComponent<AudioSource>();
            groundAudio.PlayOneShot(breakSound);
        } 

        // ok so! the scripts inside the if/then statement call on the audio to be played
        //the ontriggerenter is for when 2 colliders make contact (the parameters are specifically for 3D)
        //line 28 is specifically about which tag the game object that the script is attached to has to make contact with for the inner script to trigger
    }
}

