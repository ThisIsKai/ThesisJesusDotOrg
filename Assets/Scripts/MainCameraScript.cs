using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour {

        public Camera mainCamera;
        public float controlMidPointY;

        public GameObject ballObject;           //the ball
        public GameObject leftControl;           //the left control
        public GameObject rightControl;         //the right control
        public float camPosLockX; 					// the fixed/locked-in x pos of the camera
        public float camPosLockZ; 					// the fixed/locked-in z poz of the camera
        public float movingCamX;


	void Start () {
		
	mainCamera = Camera.main; //assigning the camera
	}
	
	// Update is called once per frame
	void Update () {

        //Vector3 cam_pos = mainCamera.transform.position; 
        //   controlMidPointY = (((leftControl.transform.position.y)+(rightControl.transform.position.y))/2);        //averaging the y-transforms of the controllers
        movingCamX = ballObject.transform.position.x; 
        controlMidPointY = (((leftControl.transform.position.y) + (ballObject.transform.position.y) + (rightControl.transform.position.y)) / 3); ;
		mainCamera.transform.position = new Vector3(movingCamX, controlMidPointY, camPosLockZ);


//		cam_pos.x = camPosLockX;
//		cam_pos.y = controlMidPointY;
//		cam_pos.z = camPosLockZ;
//		cam_pos.y = ballObject.transform.position.y;

		//Debug.Log ("ballObject pos=" + ballObject.transform.position.y);
		//Debug.Log ("controlMidpoint" + controlMidPointY);
		//Debug.Log ("cam_pos.y=" + cam_pos.y);


    }
}
