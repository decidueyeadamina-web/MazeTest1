using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player;
    public Transform teleportA;
    public Transform teleportB;
    private float warpDistance = 1.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float distance = Vector3.Distance(player.position, teleportA.position);

       if (distance <= warpDistance)
        {
            Debug.Log("hello??");
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
