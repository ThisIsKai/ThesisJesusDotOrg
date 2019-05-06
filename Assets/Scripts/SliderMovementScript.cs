using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderMovementScript : MonoBehaviour {  // SLIDER MOVEMENT SCRIPT: {ATTACHED TO BOTH THE LEFT & RIGHT SLIDER OBJECTS}
                                                     // a script that moves the slider objects up and down  
                                                     // using transform.pos based on keypresses

    //__________________________________________________________________________________________________________________________________________________________

    public bool leftFalseRightTrue;         // a bool to track if the game object is for the left or right slider
   
    public float minHeight;                 // the minimum y value for the slider
    public float maxHeight;                 // the maximum y value for the slider

    public float rate;                      // the rate modifier, altering the force of each movement

    private KeyCode leftUp = KeyCode.Q;             // the keycode for the 'Left Up' command, assigned in the inspector
    private KeyCode leftDown = KeyCode.A;           // the keycode for the 'Left Down' command, assigned in the inspector
    private KeyCode rightUp = KeyCode.O;            // the keycode for the 'Right Up' command, assigned in the inspector
    private KeyCode rightDown = KeyCode.L;          // the keycode for the 'Right Down' command, assigned in the inspector

    public float max_KeyPressLength;        // the maximum keypress length (in frames) that will register before needing keyUp to reset, set in the inspector

    private float leftUpTimer;                      // a timer keeping track if how long the "left up" key has been held down continuously for
    private float leftDownTimer;                    // a timer keeping track if how long the "left down" key has been held down continuously for
    private float rightUpTimer;                     // a timer keeping track if how long the "right up" key has been held down continuously for
    private float rightDownTimer;                   // a timer keeping track if how long the "right down" key has been held down continuously for
//__________________________________________________________________________________________________________________________________________________________________________________________________

    private void Start() // START FUNCTION
    {
    leftUpTimer = 0f ;          // set the timer to zero at the start
    leftDownTimer = 0f;         // set the timer to zero at the start
    rightUpTimer = 0f;          // set the timer to zero at the start
    rightDownTimer = 0f;        // set the timer to zero at the start
    }//END START FUNCTION

    //__________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
    private void FixedUpdate()
    {
        //**********************LEFT PLAYER**************************
        if (leftFalseRightTrue == false) // IF LEFT PLAYER
        {
            if ((Input.GetKey(leftUp)) && (leftUpTimer <= max_KeyPressLength)) // IF THE LEFTUP KEY PRESSED & TIMER IS UNDER THE MAX KEYPRESS LENGTH
            {
                transform.position += Vector3.up * rate * Time.deltaTime;
                leftUpTimer = leftUpTimer + 1;

                if (transform.position.y >= maxHeight)
                {
                    transform.position = new Vector3(transform.position.x, maxHeight, transform.position.z);
                }
            }

            if (Input.GetKeyUp(leftUp))
            {
                leftUpTimer = 0f;
            }


            //***LEFT Down
            if ((Input.GetKey(leftDown)) && (leftDownTimer <= max_KeyPressLength)) // IF THE LEFTDOWN KEY PRESSED & TIMER IS UNDER THE MAX KEYPRESS LENGTH
            {
                transform.position += Vector3.down * rate * Time.deltaTime;
                leftDownTimer = leftDownTimer + 1;

                if (transform.position.y <= minHeight)
                {
                    transform.position = new Vector3(transform.position.x, minHeight, transform.position.z);
                }
            }
            if (Input.GetKeyUp(leftDown))
            {
                leftDownTimer = 0f;
            }

        } // END IF LEFT PLAYER
        else
        {
            //**********************RIGHT PLAYER**************************

            if ((Input.GetKey(rightUp)) && (rightUpTimer <= max_KeyPressLength)) // IF THE RIGHTUP KEY PRESSED & TIMER IS UNDER THE MAX KEYPRESS LENGTH
            {
                transform.position += Vector3.up * rate * Time.deltaTime;
                rightUpTimer = rightUpTimer + 1;

                if (transform.position.y >= maxHeight)
                {
                    transform.position = new Vector3(transform.position.x, maxHeight, transform.position.z);

                }
            }

            if (Input.GetKeyUp(rightUp))
            {
                rightUpTimer = 0f;
            }


            if ((Input.GetKey(rightDown)) && (rightDownTimer <= max_KeyPressLength)) // IF THE RIGHTDOWN KEY PRESSED & TIMER IS UNDER THE MAX KEYPRESS LENGTH
            {
                transform.position += Vector3.down * rate * Time.deltaTime;
                rightDownTimer = rightDownTimer + 1;

                if (transform.position.y <= minHeight)
                {
                    transform.position = new Vector3(transform.position.x, minHeight, transform.position.z);
                }

            }//END IF GET KEY FOR RIGHT DOWN

            if (Input.GetKeyUp(rightDown))
            {
                rightDownTimer = 0f;
            }//END IF GET KEY UP FOR RIGHT DOWN

        }// END IF RIGHT PLAYER

    }// END FIXED UPADATE

}// END SLIDER MOVEMENT SCRIPT
