using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cricket : MonoBehaviour {

	public float minimumPitch = 0.9f;
	public float maximumPitch = 1.1f;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().pitch = Random.Range (minimumPitch, maximumPitch);
	}
}
