using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WarningSceneToStartScene : MonoBehaviour
{ 


    void Update()
    {
        if (Input.GetKey(KeyCode.Y))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("StartScreen");
        }//END LOAD SCENE
        if (Input.GetKey(KeyCode.N))
        {
            Application.Quit();
        }
    }//END UPDATE FUNCTION
}//END GAME OVER SCENE TO START SCREEN
