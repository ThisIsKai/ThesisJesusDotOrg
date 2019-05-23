using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {   //  BALL SCRIPT: {ATTACHED TO BALL}
                                            //  tells how the ball should move  because I'm not 
                                            //  using the physics engine for my movement or collisions

    public Transform leftSliderforBall;             // the transform of the left slider object
    public Transform rightSliderforBall;            // the transform of the right slider object
   
    public float boardWidth;                        // the width (in world space units) of the board

    private Vector3 startPos_Ball;
    private Vector3 startPos_L_Slider;
    private Vector3 startPos_R_Slider;

    public float bounce_TuningVal;

    public float ball_Accel;                        // the acceleration value of the ball
    public float ball_Veloc;                        // the velocity of the ball
    public float accel_TuningVal;                   // a value for tuning/modifying the acceleration value of the ball
    public float drag_TuningVal;                    // a value for tuning/modifying the drag force on the ball
    public GameObject resetScreen;
    //public GameObject ballResetScreen;
    //public TextMesh resetCountdownText;
    //public float resetTimer;
    //public float resetScreenTime;
    //public GameObject resetScreenObj;

    private void Start()
    {
        startPos_Ball = transform.position;
        startPos_L_Slider = leftSliderforBall.position;
        startPos_R_Slider = rightSliderforBall.position;
       
       TuningControlScript tuner = (TuningControlScript)Resources.Load("TuningData");

        ball_Accel = tuner.ball_Accel;
        bounce_TuningVal = tuner.bounce_TuningVal;
        ball_Veloc = tuner.ball_Veloc;
        drag_TuningVal = tuner.drag_TuningVal;

    }
    private void FixedUpdate()
    {
        MoveBallWithSimulatedPhysics();
    }

    private void MoveBallWithSimulatedPhysics()
    {
        if (GameManager.Instance.lives == 0)
            return;
        ball_Accel = accel_TuningVal * (leftSliderforBall.position.y - rightSliderforBall.position.y);          // calculation of the ball's acceleration
        ball_Veloc += (ball_Accel - Mathf.Sign(ball_Veloc) * (drag_TuningVal * (ball_Veloc * ball_Veloc))) * Time.fixedDeltaTime;

        Vector3 localP = transform.localPosition + Vector3.right * ball_Veloc * Time.fixedDeltaTime;   // the movement of the ball over time 
        localP.y = 0;
        localP.z = 0;

        transform.localPosition = localP;

        // calculation of the ball's velocity
        if (transform.position.x <= -boardWidth / 2)                                                              // if the ball is coming up against the left side edge of the board (a neg x value)
        {
            float delY = rightSliderforBall.position.y - leftSliderforBall.position.y;
            float delX = rightSliderforBall.position.x - leftSliderforBall.position.x;
            float slope = delY / delX;

            float leftSliderToLeftWall = -boardWidth / 2 - leftSliderforBall.position.x;

            float interceptHeight = leftSliderforBall.position.y + leftSliderToLeftWall * slope;

            Vector3 leftWallIntercept = new Vector3(-boardWidth / 2, interceptHeight, leftSliderforBall.position.z);

            ball_Veloc = 0;

            transform.position = leftWallIntercept;
        }
        else if  (transform.position.x >= boardWidth / 2)                                                              // if the ball is coming up against the right side edge of the board (a positive x val)
        {
            float delY = rightSliderforBall.position.y - leftSliderforBall.position.y;
            float delX = rightSliderforBall.position.x - leftSliderforBall.position.x;
            float slope = delY / delX;

            float leftSliderToRightWall = boardWidth / 2 - leftSliderforBall.position.x;

            float interceptHeight = leftSliderforBall.position.y + leftSliderToRightWall * slope;

            Vector3 rightWallIntercept = new Vector3(boardWidth / 2, interceptHeight, leftSliderforBall.position.z);

            ball_Veloc = 0;

            transform.position = rightWallIntercept;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        ball_Veloc = -ball_Veloc*bounce_TuningVal;
        if (other.gameObject.tag == "Hole")
        {
            GameManager.Instance.lives--;
            if (GameManager.Instance.lives == 0)
                return;
            resetScreen.SetActive(true);
            transform.position = startPos_Ball;
            leftSliderforBall.position = startPos_L_Slider;
            rightSliderforBall.position = startPos_R_Slider;
            ball_Veloc = 0f;
            //ShowResetBallScreen();

        }
    }
    //private void ShowResetBallScreen()
    //{

        //    if (resetTimer <= resetScreenTime)
        //    {
           
        //        resetTimer = resetTimer + 1;

        //    ballResetScreen.SetActive(true);
        //    resetCountdownText.text = "Next Ball";

        //}
        //    else
        //    {
          
        //        this.gameObject.SetActive(false);
        //    }

        //}


        // END FIXEDUPDATE FUNCTION
    } // END SCRIPT "BALL SCRIPT"



