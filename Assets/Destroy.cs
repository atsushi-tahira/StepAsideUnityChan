﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	GameObject targetobj;
	// Use this for initialization
	void Start () {
		targetobj = GameObject.Find ("Plane");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Destroy (targetobj);
		}

	}
}
