﻿using System.Collections.Generic;
using UnityEngine;

public class charactercontrol : MonoBehaviour {
	public float speed = 10.0F; 
	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked; 
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis ("Vertical") * speed; 
		float straffe  = Input.GetAxis ("Mouse Y") * speed; 
		translation *= Time.deltaTime; 
		straffe *= Time.deltaTime;

		transform.Translate(straffe, 0, translation); 

		if (Input.GetKeyDown ("escaps"))
			Cursor.lockState = CursorLockMode.None; 

	}
}
