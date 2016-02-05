using UnityEngine;
using System.Collections;


/*
File Name: PlayerCOntroller.cs
Author: Amandeep Singh
Last Modified By:  Amandeep Singh
Date Last Modified:  Feb 02, 2016
Program Description: Pacman game
Revision History: Revised 5 times
*/

public class PlayerController : MonoBehaviour {


    // PUBLIC INSTANCE VARIABLES
    public float speed = 5f;

    // PRIVATE INSTANCE VARIABLES
    private float _playerInput;
    private Transform _transform;
    private Vector2 _currentPosition;

    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;

        this._playerInput = Input.GetAxis("Vertical");

        // if player input is positive move upwards
        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(0,this.speed);
        }

        // if player input is negative move downwards 
        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(0, this.speed);
        }

        this._checkBounds();

        this._transform.position = this._currentPosition;
    }


    // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //Method to constraint the player in boundary
    private void _checkBounds()
    {
        // check if the plane is going out of bounds and keep it inside window boundary
        if (this._currentPosition.y < -185)
        {
            this._currentPosition.y = -185;
        }

        if (this._currentPosition.y > 185)
        {
            this._currentPosition.y = 185;
        }
    }
}
