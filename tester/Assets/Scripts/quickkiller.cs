using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quickkiller : MonoBehaviour {

    public float KillTime;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, KillTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
