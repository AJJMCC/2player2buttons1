using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Controller : MonoBehaviour {

    public float MaxDistanceY;

    private GameObject MyShip;

    public float ShipMoveSpeed;


    // Use this for initialization
    void Start()
    {
      
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && transform.position.y <= MaxDistanceY)
        {
            transform.localPosition += Vector3.up * Time.deltaTime * ShipMoveSpeed;
        }

        if (Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.UpArrow) && transform.position.y >= -MaxDistanceY)
        {
            transform.localPosition += Vector3.down * Time.deltaTime * ShipMoveSpeed;
        }

    }

    // Update is called once per frame
    void Update()
    {

        Move();

      

    }
}