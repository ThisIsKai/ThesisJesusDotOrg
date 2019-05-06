using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerGoalsScript : MonoBehaviour { // A SCRIPT ATTACHED TO THE GOAL CUBES

	public float timeUntilDestroyed = 55f;
	public float colorChangeTimer;
	bool _collision = false;

	bool thisGoalHit;

	void Start(){
		thisGoalHit = false;
	

//	float colorChangeTimer = timeUntilDestroyed;
	}//END START


	void OnCollisionEnter(Collision other) {					// collision function,for when ball hits this goal
			if(other.gameObject.tag == "Ball") {					// if the other object (the one hitting this object) has a tag that is "Ball" THEN
			thisGoalHit = true;
			_collision = true;
			//StartCountdownTimer();
			}// end  if other object is ball
	}//END ON COLLISION ENTER FUNCTION


	void Update(){

		if (thisGoalHit == true) {
			//ChangeMaterialColor ();
			GameManager.Instance.DecreaseScore ();					
		}//end if goal hit

		if (_collision == true) {
			//Debug.Log ("collision happened");
			StartCountdownTimer();
		}
	}//END UPDATE


	void StartCountdownTimer (){
//		Debug.Log (this.gameObject.name+"Countdown Timer Started");

		//timeUntilDestroyed -= (Mathf.FloorToInt(Time.deltaTime));
		if (timeUntilDestroyed > 0) {
			timeUntilDestroyed -= Time.deltaTime;
		}
//		Debug.Log (timeUntilDestroyed + "is the timeUntilDestroyed");

		if (timeUntilDestroyed <= 0) {
			Destroy (this.gameObject);													// destroy this game object (the one this script is attached to)
	
		}//END TIME UNTIL DESTROYED

	}//END START COUNTDOWN TIMER FUNCTION


}// END SCRIPT "GOALSCRIPT"
