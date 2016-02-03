using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    // PUBLIC INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;

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
        }
    }

    public int jawsNumber = 3;
    public jawsController jaws;


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

        for (int jawsCount = 0; jawsCount < this.jawsNumber; jawsCount++)
        {
            Instantiate(jaws.gameObject);
        }
    }
}
