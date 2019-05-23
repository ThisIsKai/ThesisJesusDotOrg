using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFOVChangeScript : MonoBehaviour
{

    public float baseFOV;
    public float changedFOV;
    public float speed;
    private float timer;
    public float bpmValue;
    public float myRhythm;


    void Update()
    {
        {
            Camera.main.fieldOfView = baseFOV + Mathf.Sin(timer * speed) * changedFOV;
            timer += Time.deltaTime;
          
        }
    }//end Update Function

   
     void BPMCalculations()
    {
       myRhythm = (Time.fixedTime) / (bpmValue);
    }//end BPMCalculations function


}//END CAMERA FOV CHANGE SCRIPT

