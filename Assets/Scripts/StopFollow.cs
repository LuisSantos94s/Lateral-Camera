using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopFollow : MonoBehaviour {

    CameraFollow camFollow;

	// Use this for initialization
	void Start () {

        camFollow = GameObject.Find("Main Camera").GetComponent<CameraFollow>();
    }

    private void OnTriggerEnter(Collider other)
    {
        camFollow.StopCamera();
    }

    private void OnTriggerExit(Collider other)
    {
        camFollow.ResumeCamera();
    }
}
