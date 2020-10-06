using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playHorn : MonoBehaviour {

    AudioSource audio;

	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	public void Beep () {
        audio.Play();
	}
}
