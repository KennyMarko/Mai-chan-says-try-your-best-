using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSlot : MonoBehaviour
{
    public SpriteRenderer Renderer;
 [SerializeField] private AudioSource _audioSource;
 [SerializeField] private AudioClip _completclip;

public void Placed(){

_audioSource.PlayOneShot(_completclip);

}



   
}
