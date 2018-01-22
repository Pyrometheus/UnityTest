using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed; //changes how fast the character moves
    public float jump; //changes jump height
    private Rigidbody2D rb2d;
	// Use this for initialization
	void Start() {
        rb2d = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update() {

        float moveHorizontal = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(moveHorizontal * speed, rb2d.velocity.y);

        if (Input.GetKeyDown("Space") == true)
        {
            rb2d.velocity = new Vector2(0, jump);
        }
	}
}
