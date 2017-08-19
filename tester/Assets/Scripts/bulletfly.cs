using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfly : MonoBehaviour {

    public float flyspeed;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * flyspeed* Time.deltaTime;
	}



}
