﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour {

    public AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        audio.Play();
	}

}
