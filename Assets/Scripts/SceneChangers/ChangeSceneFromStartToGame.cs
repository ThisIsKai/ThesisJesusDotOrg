using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneFromStartToGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.P))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        }//END LOAD SCENE
    }//END UPDATE FUNCTION
}
