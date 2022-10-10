using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuController : MonoBehaviour
{
   public void StartGame()
   {
     SceneManager.LoadScene(2);
   }

   public void Quit()
   {
       Application.Quit();
   }
   
   
}
