using UnityEngine;
using System.Collections;


/*
File Name:  blueGhostController.cs
Author: Amandeep Singh
Last Modified By:  Amandeep Singh
Date Last Modified:  Feb 02, 2016
Program Description: Pacman game
Revision History: Revised 5 times
*/

public class blueGhostsController : MonoBehaviour {

    // PUBLIC INSTANCE VARIABLES
    public float minVerticalSpeed = -2f;
    public float maxVerticalSpeed = 2f;
    public float minHorizontalSpeed = 5f;
    public float maxHorizontalSpeed = 10f;

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _verticalDrift;
    private float _horizontalSpeed;

    // Use this for initialization
    void Start()
    {
        // Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();

        // Reset the Cloud Sprite to the Top
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._horizontalSpeed, this._verticalDrift);
        this._transform.position = this._currentPosition;

        //Reset the position of blue ghost
        if (this._currentPosition.x <= -300)
        {
            this.Reset();
        }
    }

    //Method to reset the blue ghost
    public void Reset()
    {
        this._horizontalSpeed = Random.Range(this.minHorizontalSpeed, this.maxHorizontalSpeed);
        this._verticalDrift = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        float yPosition = Random.Range(-200f, 200f);
        this._transform.position = new Vector2(270f, yPosition);
    }
}
