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
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            //Debug.Log("click" + touch.position);
            if (spriteRenderer.bounds.Contains(touch.position))
            {
                selectedCard = true;
                Debug.Log("selectedCard");
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