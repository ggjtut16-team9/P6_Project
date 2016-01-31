﻿using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

    private bool left = true;
    private AudioSource[] source;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (left)
        {
            transform.position += new Vector3(15, 0, 0) * Time.deltaTime;
            if (transform.position.x > 50.0f) Destroy(this.gameObject);
        }
        else
        {
            transform.position -= new Vector3(15, 0, 0) * Time.deltaTime;
            if (transform.position.x < -50.0f) Destroy(this.gameObject);
        }
	}

    public void SetLeft(bool flag){
        left = flag;
    }

    public bool ReturnLeft()
    {
        return left;
    }
}
