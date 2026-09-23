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
    void Start()
    {
        canWarp = false;
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
    }

    void MoveHere()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("put words here!");
            player.position = teleportB.position;
        }
    }
}
