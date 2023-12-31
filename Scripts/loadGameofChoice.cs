using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGameofChoice : MonoBehaviour
{
  /* [SerializeField] private AudioSource flipsoundeffect;

public void OnMouseDown(){

flipsoundeffect.Play(); 
}*/
   public void PlayMemoryGame(){

SceneManager.LoadScene("MainScene");

   }
    public void PlayQUIZGame(){

SceneManager.LoadScene("QuizGame");

   }

 public void PlayMatchGame(){

SceneManager.LoadScene("matchGame");

   }
   public void QuitGame(){
Debug.Log("Game has Quit");
Application.Quit();
   }
   
    public void returnToMainMenu(){

SceneManager.LoadScene(sceneBuildIndex: 0);

   }

    public void gameChooserScreen(){

SceneManager.LoadScene(sceneBuildIndex:1);

   }
}