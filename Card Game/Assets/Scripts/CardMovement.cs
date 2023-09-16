using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMovement : MonoBehaviour
{
    bool selectedCard = false;
    private SpriteRenderer spriteRenderer;
    public Touch touch;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (spriteRenderer.bounds.Contains(touch.position))
            {
                Vector2 pos = touch.position;
                selectedCard = true;
            }
        }
        if (selectedCard)
            objectFollowMouse();
    }

    private void objectFollowMouse()
    {
        transform.position = touch.position;
    }
}