using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float MoveSpeed;

   
	// Use this for initialization
	void Start () 
	{
		MoveSpeed = 5f;	
  	}

	// Update is called once per frame
	void FixedUpdate () 
	{
        transform.Translate (MoveSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, MoveSpeed * Input.GetAxis ("Vertical") * Time.deltaTime);
	}
}
