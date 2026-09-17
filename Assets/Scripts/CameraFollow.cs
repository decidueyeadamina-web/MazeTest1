using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CameraFollow : MonoBehaviour
{   
    
    public Transform Player;
    public Vector3 offset = new Vector3 (2, 5, -15);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.position + offset;
        //transform.LookAt(Player);
    }
}
