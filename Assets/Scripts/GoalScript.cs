using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour { // A SCRIPT ATTACHED TO THE GOAL CUBES

	public float timeUntilDestroyed;
	public float colorChangeTimer;

	bool thisGoalHit;

	void Start(){
		thisGoalHit = false;
	

	}//END START


	void OnCollisionEnter(Collision other) {					// collision function,for when ball hits this goal
			if (other.gameObject.tag == "Ball") {					// if the other object (the one hitting this object) has a tag that is "Ball" THEN
			thisGoalHit = true;
			}// end  if other object is ball
	}//END ON COLLISION ENTER FUNCTION


	void Update(){

		if (thisGoalHit == true) {
			StartCountdownTimer();
			//ChangeMaterialColor ();
	//		GameManager.Instance.DecreaseScore ();					
		}//end if goal hit
	}//END UPDATE


	void StartCountdownTimer (){
	//Debug.Log (this.gameObject.name+"Countdown Timer Started");

		timeUntilDestroyed -= (Mathf.FloorToInt(Time.deltaTime));
	//	Debug.Log (timeUntilDestroyed + "is the timeUntilDestroyed");

		if (timeUntilDestroyed <= 0) {
			Destroy (this.gameObject);													// destroy this game object (the one this script is attached to)
		//	Debug.Log (this.gameObject.name+"destroyed");

		}//END TIME UNTIL DESTROYED

	}//END START COUNTDOWN TIMER FUNCTION


	//void ChangeMaterialColor (){
	//	float lerp = colorChangeTimer;
 //       colorChangeTimer = timeUntilDestroyed;
	//	Debug.Log (this.gameObject.name+ "Color Change Started");

	//	Renderer goalColor = GetComponent<Renderer>();											//get renderer for the goals

	//	goalColor.material.shader = Shader.Find("_Color");										//get the main color
	//	goalColor.material.SetColor("Color", (Color.Lerp(Color.red,Color.clear, lerp)));		//set the main color

	//	goalColor.material.shader = Shader.Find("_Specular"); 									//get the specular shader
	//	goalColor.material.SetColor("SpecColor",(Color.Lerp(Color.red,Color.clear, lerp)));	//set the specular shader

	//	goalColor.material.shader = Shader.Find(" _EmissionColor"); 							//get emissive shader
	//	goalColor.material.SetColor("EmissColor", (Color.Lerp(Color.red,Color.clear, lerp)));	//set the emissive shader
	
	//}//end change material color

}// END SCRIPT "GOALSCRIPT"
