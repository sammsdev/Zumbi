﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageExplosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("CUIDADO! FOGO!");
        Shader.instance.EnableShader();
    }
}
