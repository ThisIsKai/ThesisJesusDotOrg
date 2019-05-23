using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour {


    public float levelTimer;
	public int startingBallCount;
	private int ballsRemaining;

	public static GameManager Instance;

	public Camera ballCamera;
	public Camera boardCamera;
   

    public GameObject endPortal;

    public GameObject gameOverScreen;
    public GameObject resetScreen;

    private bool gameIsPaused;
    private float scoreClearedPercent;
    public float totalFinalScore;
    public float scoreTimeBonus;
    public float scoreLivesBonus;
    public float scoreBuildingsBonus;
    public float clearedPercentMultiplier;
    public float livesBonusMultiplier;
    public float buildingsHitMultiplier;
    public float buildingsRemainingMultiplier;
    public float timeBonusMultiplier;
    public int lives = 5;
    public TextMeshPro cubesLeftText;

    public KeyCode leftPlayerX = KeyCode.Z;
    public KeyCode rightPlayerX = KeyCode.U;

    public KeyCode leftPlayerPause = KeyCode.D;
    public KeyCode rightPlayerPause = KeyCode.B;
    public KeyCode leftPlayerStar = KeyCode.C;
    public KeyCode rightPlayerStar = KeyCode.M;
    public KeyCode leftPlayerCheck = KeyCode.W;
    public KeyCode rightPlayerCheck = KeyCode.P;
   
    public int goalsInLevel;
   


    public int current_score;
    int goalsHit;
    public int goalsRemaining;
    private float highScore;
  
    public TextMesh highScoreText;
    public TextMesh yourScoreText;


    void Awake () {
		Instance = this;
        highScore = PlayerPrefs.GetFloat("highscore", 0);

	}

	void Start () {

        levelTimer = 0;
		ballCamera = Camera.main; //assigning the camera
		cubesLeftText.gameObject.SetActive(true);
        current_score = 0;	//get cubes number
		ballCamera.enabled = true;
		boardCamera.enabled = false;

	}//END START

	void Update(){

        //levelTimer = levelTimer + 1;

		if (ballCamera.enabled == true)
        {
			cubesLeftText.gameObject.SetActive(true);
            current_score = goalsInLevel - goalsRemaining;
            cubesLeftText.text = "Buildings Destroyed : " + current_score + "/" + goalsInLevel; //telling the text to include the current number of balls for the player
        }
		
        if (ballCamera.enabled == false) 
        {
			cubesLeftText.gameObject.SetActive(false);

		}

        if ((Input.GetKeyDown(leftPlayerPause)) && (Input.GetKey(rightPlayerPause)))
        {
			SwitchCamera ();
		}//if cam swap key 

        cubesLeftText.text += "\nLIVES: " + lives;

        if (gameIsPaused == true) 
        {
         
        }

        if ( (Input.GetKeyDown(leftPlayerX) && Input.GetKeyDown(rightPlayerX)))
        {
            ExitLevel();
        }


        if ( (Input.GetKeyDown(rightPlayerX) && Input.GetKeyDown(rightPlayerStar)) || (Input.GetKeyDown(leftPlayerX) && Input.GetKeyDown(leftPlayerStar)))

        {
            QuitGame();
        }


        if (lives <= 0)
        {
            if (!gameOverScreen.activeInHierarchy)
            {
                highScore = PlayerPrefs.GetFloat("highscore", 0);
                if (current_score > highScore)
                {
                    Debug.Log("HIGH SCORE " + highScore);
                    PlayerPrefs.SetFloat("new highscore", current_score);
                    Debug.Log("NEW HIGH SCORE " + highScore);

                }
            }
            gameOverScreen.SetActive(true);
            highScoreText.text = "HIGH SCORE: " + highScore;
            yourScoreText.text = "SCORE: " + current_score;
            //totalScoreText.text = "total final score" + totalFinalScore;
        }
       
       if (goalsRemaining <= 42)
        {
            LoadEndPortal();
        }

    }//END UPDATE

	
    void SwitchCamera (){
		ballCamera.enabled = !ballCamera.enabled;
		boardCamera.enabled = !boardCamera.enabled;

        if(boardCamera.enabled == true)
        {
            PauseGame();
        } 
        if (ballCamera.enabled == true)
        {
            UnPauseGame();
        }

    }//END SWITCH CAMERA FUNCTION


    void PauseGame()
    {
        Time.timeScale = 0f;
        gameIsPaused = true;

    }
    void UnPauseGame()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void LoadEndPortal()
    {
        endPortal.gameObject.SetActive(true);

    }

    void ExitLevel()
    {
        // do a scene manager thing to take it to 
    }

    void QuitGame()
    {
        Application.Quit();

    }


    //    void CalculateScore()
    //    {
    //        scoreTimeBonus = levelTimer * timeBonusMultiplier;
    //        scoreLivesBonus = lives * livesBonusMultiplier;
    //        scoreBuildingsBonus = current_score * buildingsHitMultiplier;
    //        scoreClearedPercent = clearedPercentMultiplier * (current_score / goalsInLevel);
    //        totalFinalScore = scoreTimeBonus + scoreLivesBonus + scoreBuildingsBonus + scoreClearedPercent;

    //}



}//END GAME MANAGER SCRIPT

