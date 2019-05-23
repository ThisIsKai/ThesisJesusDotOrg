using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreenTrackingScript : MonoBehaviour
{
    Camera sceneCameraforGameOver;
    bool gameIsOver;
    Vector3 gameOverScreenPos;
    Vector3 sceneCameraforGameOverPos;


    void Start()
    {
        gameIsOver = false;
        sceneCameraforGameOver = Camera.main;

    }//end Start function


    void Update()
    {
        if (gameIsOver ==true) 
        {
        this.gameObject.transform.position = gameOverScreenPos;
            sceneCameraforGameOver.transform.position = sceneCameraforGameOverPos;
            gameOverScreenPos.y = sceneCameraforGameOverPos.y;
            gameOverScreenPos = this.gameObject.transform.position;
         } //end if gameIsOver == true
    }//end Update function

}//END GAME OVER SCREEN TRACKING SCRIPT

