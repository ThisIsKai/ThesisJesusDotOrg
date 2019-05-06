using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.SceneManagement;
using System;

public class GameManager : MonoBehaviour {
	


	//private int currentScore;
	//public AudioSource game_over_source;
	//public AudioSource goal_hit_source; 
	//public AudioSource restart_sound_source;
	//public AudioClip game_over_clip;
	//public AudioClip goal_hit_clip;
	//public AudioClip restart_sound_clip;
	public int startingBallCount;
	private int ballsRemaining;
    public int current_score;
	public static GameManager Instance;
	public KeyCode camSwapKey;
	public Camera ballCamera;
	public Camera boardCamera;
    int goalsInLevel;
    int goalsHit;
    int goalsRemaining;
    public int lives = 3;
    public GameObject gameOverScreen;


	public TextMeshPro cubesLeftText;


	void Awake () {
		Instance = this;
	}

	// Use this for initialization
	void Start () {
		
		ballCamera = Camera.main; //assigning the camera
		cubesLeftText.gameObject.SetActive(true);
        goalsInLevel = GameObject.FindGameObjectsWithTag("Goal").Length;


        current_score = 0;	//get cubes number


		ballCamera.enabled = true;
	
		boardCamera.enabled = false;

	}//END START

	void Update(){
		if (ballCamera.enabled == true){
			cubesLeftText.gameObject.SetActive(true);
            goalsRemaining = GameObject.FindGameObjectsWithTag("Building").Length;
            current_score = goalsInLevel - goalsRemaining;
            cubesLeftText.text = "Buildings Destroyed : " + current_score + "/" + goalsInLevel; //telling the text to include the current number of balls for the player
			}
		if (ballCamera.enabled == false) {
			cubesLeftText.gameObject.SetActive(false);

		}
		if (Input.GetKeyDown(camSwapKey)) {
			SwitchCamera ();
		}//if cam swap key 
        cubesLeftText.text += "\nLIVES: " + lives;
        if (lives == 0)
        {
            gameOverScreen.SetActive(true);
        }
    }//END UPDATE

	void SwitchCamera (){
		ballCamera.enabled = !ballCamera.enabled;
		boardCamera.enabled = !boardCamera.enabled;

	}//END SWITCH CAMERA FUNCTION

	void OnTriggerEnter(Collider other) {														// ONCOLLISIONENTER FUNCTION
		if (other.gameObject.tag == "Backboard") {

			GameOver();
		}// end if no balls left
	} //END ON COLLISION

	public void DecreaseScore() {

	}//END DECREASE SCORE

	void GameOver (){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("GameOverScreen");

	}// END GAME OVER FUNCTION



}//END GAME MANAGER SCRIPT

