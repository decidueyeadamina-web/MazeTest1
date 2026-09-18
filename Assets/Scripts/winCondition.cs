using UnityEngine;

public class winCondition : MonoBehaviour
{   
    public Transform player;
    public Transform winSpot;
    public GameObject winUI;
    private float winDistance = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

   void Update()
    {
       float distance = Vector3.Distance(player.position, winSpot.position);

       if (distance <= winDistance)
        {
            YouWin();
        }
    }

    void YouWin()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("put words here!");
            winUI.SetActive(true);
        }
    }
}
