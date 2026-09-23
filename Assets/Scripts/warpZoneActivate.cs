using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class warpZoneActivate : MonoBehaviour
{   
    public GameObject teleportZone;

   // public Teleport teleport;

    public spriteController SC;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        teleportZone.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (SC.warpSpot == true)
        {
            Debug.Log("warping true");
            teleportZone.SetActive(true);
        }
    }
}
