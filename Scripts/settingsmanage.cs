using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEditor;

public class settingsmanage : MonoBehaviour
{

   [SerializeField] private AudioSource _audioSource;


  [SerializeField] private Slider _slider;
   private int minVal,MaxVal;
   

   public void  volumeController(){

    _audioSource.volume= _slider.value;
   }

 
}
