using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{   
    //public Transform player;
    //public Transform resetFloor;

    //public float canReset = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
       //float distance = Vector3.Distance(player.position, resetFloor.position);

       //if (distance <= canReset)
        //{   
            //Debug.Log("is this thing on??");
            //SceneManager.LoadScene("SampleScene");
        //}

        //I tried using the distance and position classes for an if then to reset the scene, but it only worked when the object was small
        //using OnTriggerEnter for a scene reset instead and should ask Giselle about this after class!
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("reset"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
