using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingColliderTriggeringScript : MonoBehaviour { // {ATTACHED TO THE GOAL CUBES}

	public float timeUntilDestroyed;
	//public float colorChangeTimer;

	bool thisBuildingHit;
   Collider thisBuildingCollider;

	void Start(){
        thisBuildingHit = false;
        thisBuildingCollider = GetComponent<BoxCollider>();
        thisBuildingCollider.enabled = true;


    }//END START


	void OnCCollisionEnter(Collision other) {					// collision function,for when ball hits this goal
			if(other.gameObject.tag == "Ball") {                    // if the other object (the one hitting this object) has a tag that is "Ball" THEN
            thisBuildingHit = true;
            thisBuildingCollider.enabled = false;
			}// end  if other object is ball
	}//END ON COLLISION ENTER FUNCTION


	void Update(){

		if (thisBuildingHit == true) {
            thisBuildingCollider.enabled = false;


			StartCountdownTimer();
			//ChangeMaterialColor ();
		//	GameManager.Instance.DecreaseScore ();					
		}//end if goal hit
	}//END UPDATE


	void StartCountdownTimer (){
	//Debug.Log (this.gameObject.name+"Countdown Timer Started");

	timeUntilDestroyed -= (Mathf.FloorToInt(Time.deltaTime));
		//Debug.Log (timeUntilDestroyed + "is the timeUntilDestroyed");

		if (timeUntilDestroyed <= 0) {
			Destroy (this.gameObject);													// destroy this game object (the one this script is attached to)
		//	Debug.Log (this.gameObject.name+"destroyed");

		}//END TIME UNTIL DESTROYED

	}//END START COUNTDOWN TIMER FUNCTION


}// END SCRIPT "GOALSCRIPT"
