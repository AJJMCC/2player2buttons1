using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Controller : MonoBehaviour {

    

    public float MaxDistanceY;

    private GameObject MyShip;

    public float ShipMoveSpeed;

    


	// Use this for initialization
	void Start ()
    {
       
       
    }

    void Move()
    {
       if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && transform.position.y <= MaxDistanceY)
        {
            transform.localPosition += Vector3.up * Time.deltaTime * ShipMoveSpeed;
        }

        if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W) && transform.position.y >= -MaxDistanceY)
        {
            transform.localPosition += Vector3.down * Time.deltaTime * ShipMoveSpeed;
        }

    }

    
	
	// Update is called once per frame
	void Update ()
    {

        Move();
    }
}
