using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player;
    public Transform teleportA;
    public Transform teleportB;
    public float warpDistance = 5f;

    public bool canWarp;
    public bool justWarped;

    public GameObject warpVFX;
    public GameObject teleportedVFX;

    //fist time setting up a timer yikes

    public float Timer = 1f;
    void Start()
    {
        canWarp = false;
        warpVFX.SetActive(false);
        teleportedVFX.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       float distance = Vector3.Distance(player.position, teleportA.position);

       if (distance <= warpDistance)
        {   
            canWarp = true;
            //Debug.Log("hello??");
            MoveHere();
        }

        if (canWarp == true)
        {
            warpVFX.SetActive(true);
        }

        if (canWarp != true)
        {
            warpVFX.SetActive(false);
        }

        if (justWarped == true)
        {
            Timer -= Time.deltaTime;
        }

        if (justWarped == true && Timer <= 0.0f)
        {
            teleportedVFX.SetActive(false);
        }

        if (Timer <= 0.0f)
        {
            Timer = 0.0f;
        }
    }

    void MoveHere()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("put words here!");
            player.position = teleportB.position;

            teleportedVFX.SetActive(true);
            justWarped = true;
            Timer -= Time.deltaTime;
        }
    }
}
