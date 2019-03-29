using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject top;
    Vector3 mesafe;
	void Start () {
        mesafe = transform.position - top.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = top.transform.position + mesafe;
	}
}
