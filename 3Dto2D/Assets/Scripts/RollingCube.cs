using UnityEngine;

public class RollingCube : MonoBehaviour {
    public float speed = 5;
	// Use this for initialization
	void Start () {
		    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            GetComponent<Rigidbody>().angularVelocity = Vector3.forward * Input.GetAxisRaw("Vertical") * speed;
        }
            if (Input.GetAxisRaw("Horizontal")!=0){
            GetComponent<Rigidbody>().angularVelocity = Vector3.right * Input.GetAxisRaw("Horizontal") * speed;
        }

	}
}
