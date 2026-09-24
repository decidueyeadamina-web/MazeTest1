using UnityEngine;
using System.Numerics;

public class Rotate : MonoBehaviour
{   
    //hi this script is taken from what I've learned in my last coding class (how to rotate things automatically) but altered to mess with turn speed
    //i didn't use AI i know what all of these things mean at a basic level

    public float turnSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new UnityEngine.Vector3(0, 0, 10) * Time.deltaTime); 
        //transform.rotate means to make this thing move around its own axis, using vector 3 will have 3 parameters for the x, y, and z access
        //bc my parameters are integers these are static speeds, and Time.deltaTime is the change over time from the last frame
    }
}

