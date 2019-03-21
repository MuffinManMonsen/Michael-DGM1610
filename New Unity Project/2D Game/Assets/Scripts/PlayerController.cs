using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Player movement variables
	public float moveSpeed; 
	public float jumpHeight;
	
	//Player grounded variables
	private bool grounded;
	public Transform groundcheck;
	public float groundcheckRadius;
	public LayerMask whatIsGround;

	// Use this for initialization
	void Start () {
		//Default to true on grounded
		
		
	}
	
	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckRadius, whatIsGround);
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		else if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}	
		
		// Makes player jump
		if(Input.GetKeyDown(KeyCode.W)&& grounded){
			Jump();
		}
	
	}

	void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
	}
}
