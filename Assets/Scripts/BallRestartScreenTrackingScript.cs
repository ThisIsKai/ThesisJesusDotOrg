using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRestartScreenTrackingScript : MonoBehaviour
{
    Camera sceneCameraforBallReset;
    bool ballBeingReset;
    Vector3 ballResetScreenPos;
    Vector3 sceneCameraforBallResetPos;
    public float resetTimer;
    public float resetScreenTime;
    public TextMesh resetCountdownDisplay;

    void Start()
    {
        sceneCameraforBallReset= Camera.main;
        ballBeingReset = false;
        resetTimer = 0;
    }//end Start function

    private void OnEnable()
    {
        resetTimer = 0f;
    }

    void Update()
    {
        if (true)//ballBeingReset == true) 
        {

            if (resetTimer <= resetScreenTime)
            {
                Time.timeScale = 0f;
                this.gameObject.SetActive(true);
                resetTimer += Time.unscaledDeltaTime;
                resetCountdownDisplay.text = ""+ resetTimer;
                //this.gameObject.transform.position = ballResetScreenPos;
                //sceneCameraforBallReset.transform.position = sceneCameraforBallResetPos;
                //ballResetScreenPos.y = sceneCameraforBallResetPos.y;
                //ballResetScreenPos = this.gameObject.transform.position;
            }
            else 
            { 
            Time.timeScale = 1f;
                ballBeingReset = false;
            this.gameObject.SetActive(false);
            }
        }
      
    }//end Update function


}//END GAME OVER SCREEN TRACKING SCRIPT

