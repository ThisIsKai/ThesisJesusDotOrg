using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenToGameScene: MonoBehaviour
{ 
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
        }//END LOAD SCENE
    }//END UPDATE FUNCTION
}//END GAME OVER SCENE TO START SCREEN
