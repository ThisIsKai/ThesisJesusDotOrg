using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneToStartScreenScript : MonoBehaviour
{ 
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.U))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("StartScreen");
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.P))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        }
    }//END UPDATE FUNCTION
}//END GAME OVER SCENE TO START SCREEN
