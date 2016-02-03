using UnityEngine;
using System.Collections;

public class RewardController : MonoBehaviour {

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

        if (this._currentPosition.x <= -300)
        {
            this.Reset();
        }
    }



    public void Reset()
    {
        float yPosition = Random.Range(-200f, 200f);
        this._transform.position = new Vector2(270f, yPosition);
    }
}
