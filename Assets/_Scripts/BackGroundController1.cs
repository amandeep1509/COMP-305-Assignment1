using UnityEngine;
using System.Collections;


/*
File Name:  BackGroundController.cs
Author: Amandeep Singh
Last Modified By:  Amandeep Singh
Date Last Modified:  Feb 02, 2016
Program Description: Pacman game
Revision History: Revised 5 times
*/

public class BackGroundController1 : MonoBehaviour {

    // PUBLIC INSTANCE VARIABLES
    public float speed = 3f;

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;

    // Use this for initialization
    void Start()
    {
        // Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();

        // Reset the Ocean Sprite to the Top
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed, 0);
        this._transform.position = this._currentPosition;

        //reset the image when out of focus
        if (this._currentPosition.x <= -620)
        {
            this.Reset();
        }
    }

    //Method to reset the image
    public void Reset()
    {
        this._transform.position = new Vector2(600f, 0);
    }
}
