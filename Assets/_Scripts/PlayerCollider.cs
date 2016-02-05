using UnityEngine;
using System.Collections;


/*
File Name:  PlayerCollider.cs
Author: Amandeep Singh
Last Modified By:  Amandeep Singh
Date Last Modified:  Feb 02, 2016
Program Description: Pacman game
Revision History: Revised 5 times
*/

public class PlayerCollider : MonoBehaviour {

    // PRIVATE INSTANCE VARIABLES 
    private AudioSource[] _audioSources;
    private AudioSource _enemySound;
    private AudioSource _rewardSound;
    public GameController gameController;



    // Use this for initialization
    void Start () {
        //initalise the audiosources array 
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._enemySound = this._audioSources[1];
        this._rewardSound = this._audioSources[2];
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    //Method to detect collisions
    public void OnTriggerEnter2D(Collider2D other)
    {
        //Collision with enemy
        if (other.gameObject.CompareTag("Jaws"))
        {
            this._enemySound.Play();
            this.gameController.LivesValue -= 1;
           
        }

        //Collision with reward object
        if (other.gameObject.CompareTag("Reward"))
        {
   
            this._rewardSound.Play();
            this.gameController.ScoreValue += 100;

        }
    }
}
