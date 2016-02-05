using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // PUBLIC INSTANCE VARIABLES
    public RewardController reward;
    public PlayerController player;
    public enemyController redGhost;
    public blueGhostsController blueGhost;
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public Text HighScoreLabel;
   // public Button RestartButton;

    // PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;

    [SerializeField]
    private AudioSource _gameOverSound;

    // PUBLIC ACCESS METHODS 
    public int ScoreValue
    {
        get
        {
            return _scoreValue;

        }
        set
        {
            this._scoreValue = value;
            Debug.Log(this._scoreValue);
            this.ScoreLabel.text = "Score: " + this._scoreValue;

        }
    }
    public int LivesValue
    {
        get
        {
            return _livesValue;
        }
        set
        {
            this._livesValue = value;
            Debug.Log(this._livesValue);
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else {
                this.LivesLabel.text = "lives: " + this._livesValue;
            }
        }
    }

    public int enemyNumber1 = 3;
    public enemyController enemy1;

    public int enemyNumber2 = 3;
    public blueGhostsController enemy2;




    // Use this for initialization
    void Start()
    {
        this._initialize();



    }

    // Update is called once per frame
    void Update()
    {

    }

    //PRIVATE METHODS ++++++++++++++++++

    //Initial Method
    private void _initialize()
    {
        this.ScoreValue = 0;
        this.LivesValue = 5;

        this.GameOverLabel.gameObject.SetActive(false);
        this.HighScoreLabel.gameObject.SetActive(false);
    //    this.RestartButton.gameObject.SetActive(false);

        for (int enemyCount = 0; enemyCount < this.enemyNumber1; enemyCount++)
        {
            Instantiate(enemy1.gameObject);
           
        }
        for (int enemyCount = 0; enemyCount < this.enemyNumber2; enemyCount++)
        {
            
            Instantiate(enemy2.gameObject);
        }
    }

    private void _endGame()
    {
        
        this.HighScoreLabel.text = "High Score: " + this._scoreValue;
        this.GameOverLabel.gameObject.SetActive(true);
        this.HighScoreLabel.gameObject.SetActive(true);
        this.LivesLabel.gameObject.SetActive(false);
        this.ScoreLabel.gameObject.SetActive(false);
        this.player.gameObject.SetActive(false);
        this.redGhost.gameObject.SetActive(false);
        this.blueGhost.gameObject.SetActive(false);
        this._gameOverSound.Play();
       // this.RestartButton.gameObject.SetActive(true);
       
    }


    // PUBLIC METHODS
    /*
    public void RestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

*/
}
