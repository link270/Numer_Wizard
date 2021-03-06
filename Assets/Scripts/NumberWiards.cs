﻿using UnityEngine;
using System.Collections;

public class NumberWiards : MonoBehaviour {
	// Use this for initialization
	int max = 1001;
	int min = 1;
	int guess = 500;

	void Start () {
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but don't tell me.");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow for higher, down for lower, return for equal");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess;
			guess = (max + min) / 2;
			print ("Is the number higher or lower than " + guess + "?");
		}else if (Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			guess = (max + min) / 2;
			print ("Is the number higher or lower than " + guess + "?");
		}else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won");
		}
	}
}