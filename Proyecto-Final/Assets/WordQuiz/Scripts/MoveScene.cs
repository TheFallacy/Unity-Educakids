using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
   
   public void ButtonMoveScene(string level){
        SceneManager.LoadScene(level);
   }
    
}
