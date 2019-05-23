using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneFromWarningToStart : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("StartScreen");
        }//END LOAD SCENE
        if (Input.GetKeyDown(KeyCode.N))
        {
            Application.Quit();
        }
    }//END UPDATE FUNCTION
}
