using UnityEngine;

public class spriteController : MonoBehaviour
{   
    public Sprite standingSprite;
    public Sprite rightMovingSprite;
    public Sprite leftMovingSprite;
    public Sprite castableSprite;
    private SpriteRenderer spriteRenderer;

    // transforms to sense casting
    public Transform Player;
    public Transform Teleport1;
    public Transform Teleport2;
    public Transform Teleport3;
    public Transform Teleport4;
    public Transform Teleport5;

    // floats for sense distance

    public float canTeleport = 5f;

    // bool script call test
    public bool warpSpot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer.sprite == null) 
        spriteRenderer.sprite = standingSprite; 

        warpSpot = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            spriteRenderer.sprite = rightMovingSprite;
            
        } 
        else
        {
            spriteRenderer.sprite = standingSprite;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
        {
            spriteRenderer.sprite = leftMovingSprite;
        } 
        else
        {
            //spriteRenderer.sprite = standingSprite;
        }

        //teleport sprite turn on

        float distance1A = Vector3.Distance(Player.position, Teleport1.position);

        if (distance1A <= canTeleport)
        {
            spriteRenderer.sprite = castableSprite; 
            warpSpot = true;
        }

        float distance2A = Vector3.Distance(Player.position, Teleport2.position);

        if (distance2A <= canTeleport)
        {
            spriteRenderer.sprite = castableSprite; 
            warpSpot = true;
        }
        float distance3A = Vector3.Distance(Player.position, Teleport3.position);

        if (distance3A <= canTeleport)
        {
            spriteRenderer.sprite = castableSprite; 
            warpSpot = true;
        }
        float distance4A = Vector3.Distance(Player.position, Teleport4.position);

        if (distance4A <= canTeleport)
        {
            spriteRenderer.sprite = castableSprite;
            warpSpot = true; 
        }
        float distance5A = Vector3.Distance(Player.position, Teleport5.position);

        if (distance5A <= canTeleport)
        {
            spriteRenderer.sprite = castableSprite; 
            warpSpot = true;
        }

    }

}
