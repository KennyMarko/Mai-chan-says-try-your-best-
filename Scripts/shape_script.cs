using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Tilemaps;

public class shape_script : MonoBehaviour
{
    [SerializeField] private GameObject unknown;
    [SerializeField] private shapeGameController gameController;
    [SerializeField] private AudioSource flipsoundeffect;
    
    //Gameobject toEnable, toDisable
    // public gameobject nxtlvlbutton, trophysign, achievementsign;

    //public Image oldImage;
//public Sprite newImage;
   // [SerializeField] private Animation flipanimation;

    /**public bool GetV()
    {
        return flipanimation.Play();
        
    }*/


    public void OnMouseDown()
    {
        flipsoundeffect.Play(); 

        //GetV();
        if (unknown.activeSelf )
        {
            unknown.SetActive(false);
            gameController.imageOpened(this);
        }
    }

    private int _spriteId;
    public int spriteId
    {
        get { return _spriteId; }
    }
/*public void changeImage(){

    oldImage.sprite = newImage;
}*/
    public void ChangeSprite(int id,Sprite image)
    {
        _spriteId = id;
        GetComponent<SpriteRenderer>().sprite = image; //Gets the sprite renderer component to change the sprite.
    }

    public void Close()
    {
        unknown.SetActive(true); // Hide image
    }

/*public void loadnextlevel(){
unknown;
foreach (GameObject obj in get)

    if(unknown.activeSelf == false)
}*/
    
}
