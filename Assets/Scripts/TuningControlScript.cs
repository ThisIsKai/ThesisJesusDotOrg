using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "tuning", menuName = "tuning", order = 0)]

public class TuningControlScript : ScriptableObject
{
    public float minHeight;                        // the minimum y value for the slider
    public float maxHeight;                        // the maximum y value for the slider

    //sliders
    public float rate;                             // the rate modifier, altering the force of each movement

    //ball
    public float bounce_TuningVal;
    public float ball_Accel;                        // the acceleration value of the ball
    public float ball_Veloc;                        // the velocity of the ball
    public float accel_TuningVal;                   // a value for tuning/modifying the acceleration value of the ball
    public float drag_TuningVal;                    // a value for tuning/modifying the drag force on the ball

    //sliders
    public KeyCode leftUp = KeyCode.Q;             // the keycode for the 'Left Up' command, assigned in the inspector
    public KeyCode leftDown = KeyCode.A;           // the keycode for the 'Left Down' command, assigned in the inspector
    public KeyCode rightUp = KeyCode.O;            // the keycode for the 'Right Up' command, assigned in the inspector
    public KeyCode rightDown = KeyCode.L;          // the keycode for the 'Right Down' command, assigned in the inspector
    public float max_KeyPressLength;               // the maximum keypress length (in frames) that will register before needing keyUp to reset, set in the inspector
    public float keyPressValueDecay;
    public AnimationCurve impulseCurve;
}