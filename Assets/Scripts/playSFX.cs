using UnityEngine;

public class playSFX : MonoBehaviour
{   
    //hi again! This is also a script I made in a games tech class a year ago.
    // I can tell you what these mean generally and I changed things around from what I originally used for this assignment

    public AudioClip soundEffect;
    public AudioSource sourceAudio;

    //these are some parts I actually don't get a lot! I know Audio clip is what I use as a place on the script to link the .wav file
    // AudioSource is how I attach that component to this script

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlaySound()
    {
        sourceAudio = GetComponent<AudioSource>();
        sourceAudio.PlayOneShot(soundEffect);
    }
}

