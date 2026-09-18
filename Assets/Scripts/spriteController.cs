using UnityEngine;

public class spriteController : MonoBehaviour
{   
    public Sprite standingSprite;
    public Sprite rightMovingSprite;
    public Sprite leftMovingSprite;
    public Sprite castableSprite;
    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    if (spriteRenderer.sprite == null) 
        spriteRenderer.sprite = standingSprite; 
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

    }

}
