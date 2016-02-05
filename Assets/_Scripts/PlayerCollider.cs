using UnityEngine;
using System.Collections;

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
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Jaws"))
        {
            // Debug.Log("island collision");
            this._enemySound.Play();
            this.gameController.LivesValue -= 1;
           
        }

        if (other.gameObject.CompareTag("Reward"))
        {
            // Debug.Log("cloud collision");
            this._rewardSound.Play();
            this.gameController.ScoreValue += 100;

        }
    }
}
