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

    // NEED TO DO --- ball respawn/lives , high score tracking, game over, pause menu, music
    // ball bonus score -  
    // time bonus score
    // building base score

//	public float controlMidPointY;

	public TextMeshPro cubesLeftText;


	void Awake () {
		Instance = this;
	}

	// Use this for initialization
	void Start () {
		
		ballCamera = Camera.main; //assigning the camera
		//cubesLeftText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<TextMesh>();
		cubesLeftText.gameObject.SetActive(true);
        goalsInLevel = GameObject.FindGameObjectsWithTag("Goal").Length;
        //GameObject[] taggedBldgs = new GameObject[0];
        //taggedBldgs = GameObject.FindGameObjectsWithTag("Building");
        //foreach(GameObject g in taggedBldgs)
        //{
        //    Debug.Log(g.gameObject.name + " is a child of " + g.transform.parent.name);
        //}

        current_score = 0;	//get cubes number

//*		game_over_source = this.gameObject.GetComponent<AudioSource>;
//*		goal_hit_source = this.gameObject.GetComponent<AudioSource>;
//*		restart_sound_source = this.gameObject.GetComponent<AudioSource>;
		//game_over_source.loop = false;
		//goal_hit_source.loop = false;
		//restart_sound_source.loop = false;
		ballCamera.enabled = true;
	
		boardCamera.enabled = false;

//		string fullFilePath = Application.persistentDataPath + Path.DirectorySeparatorChar + "SaveData.txt";
//		if (File.Exists(fullFilePath)) {
//			string highScoreString = File.ReadAllText(fullFilePath);
//			highScore = int.Parse(highScoreString);
//*		PlayerScore.scoreTextReadOut = GameObject.Find ("ScoreText").GetComponent<Text> ();
	}//END START

	void Update(){
		if (ballCamera.enabled == true){
			cubesLeftText.gameObject.SetActive(true);
            //goalsInLevel = GameObject.FindGameObjectsWithTag("Goal").Length;
            goalsRemaining = GameObject.FindGameObjectsWithTag("Building").Length;
            //Debug.Log(goalsRemaining);
            current_score = goalsInLevel - goalsRemaining;
            cubesLeftText.text = "Buildings Destroyed : " + current_score + "/" + goalsInLevel; //telling the text to include the current number of balls for the player
			}
		if (ballCamera.enabled == false) {
			cubesLeftText.gameObject.SetActive(false);

		}
		if (Input.GetKeyDown(camSwapKey)) {
			SwitchCamera ();
		}//if cam swap key 

	
		}//END UPDATE

	void SwitchCamera (){
		ballCamera.enabled = !ballCamera.enabled;
		boardCamera.enabled = !boardCamera.enabled;

	}//END SWITCH CAMERA FUNCTION

	void OnTriggerEnter(Collider other) {														// ONCOLLISIONENTER FUNCTION
		if (other.gameObject.tag == "Backboard") {
//			game_over_source.PlayOneShot (game_over_clip);
//			game_over_source.Stop(); 
			GameOver();
		}// end if no balls left
	} //END ON COLLISION

	public void DecreaseScore() {
	//	current_score.currentScore -= 1;
	}//END DECREASE SCORE

	void GameOver (){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("GameOverScreen");

	}// END GAME OVER FUNCTION



}//END GAME MANAGER SCRIPT

