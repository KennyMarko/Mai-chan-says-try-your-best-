using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScriptRestart : MonoBehaviour
{
   
    [SerializeField] private shapeGameController gameController;
    [SerializeField] private string functionOnClick;


    public void OnMouseOver()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if(sprite != null)
        {
            sprite.color = Color.magenta;
        }
    }

    public void OnMouseDown()
    {
        transform.localScale = new Vector3(0.3f, 0.3f, 1.0f);
    }

    public void OnMouseUp()
    {
        transform.localScale = new Vector3(0.2f, 0.2f, 1.0f);
        if(gameController != null)
        {
            gameController.SendMessage(functionOnClick); //optimize this code later. its unnecessary
        }
    }

    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = Color.white;
        }
    }


}
