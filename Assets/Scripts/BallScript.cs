using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {   //  BALL SCRIPT: {ATTACHED TO BALL}
                                            //  tells how the ball should move  because I'm not 
                                            //  using the physics engine for my movement or collisions

    public Transform leftSliderforBall;             // the transform of the left slider object
    public Transform rightSliderforBall;            // the transform of the right slider object
    public float ball_Accel;                        // the acceleration value of the ball
    public float ball_Veloc;                        // the velocity of the ball
    public float accel_TuningVal;                   // a value for tuning/modifying the acceleration value of the ball
    public float drag_TuningVal;                    // a value for tuning/modifying the drag force on the ball
    public float boardWidth;                        // the width (in world space units) of the board
    public float bounce_TuningVal;

    private void FixedUpdate()
    {
        MoveBallWithSimulatedPhysics();
    }

    private void MoveBallWithSimulatedPhysics()
    {

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

        if (other.gameObject.tag == "Buildings")
        {
          //  Debug.Log("turn around");
        }
    }


    // END FIXEDUPDATE FUNCTION
} // END SCRIPT "BALL SCRIPT"



