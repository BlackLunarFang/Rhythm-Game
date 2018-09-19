using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCube : MonoBehaviour {

    public GameObject Cube;
    public Vector3 offset;
	// Use this for initialization
	void Start () {

        offset = transform.position - Cube.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Cube.transform.position + offset;
    }
}
