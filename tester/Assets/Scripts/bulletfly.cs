using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfly : MonoBehaviour {

    public float flyspeed;
    private float LifeTime;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
        LifeTime += Time.deltaTime;
        transform.position += transform.forward * flyspeed* Time.deltaTime;
	}
    void OnCollisionEnter(Collision other)
    {
        if (LifeTime >= 0.3f && other.gameObject.GetComponentInParent<P2Controller>() != null)
        {
            GameManager.Instance.P1Wins++;

        }
        else if (LifeTime >= 0.3f && other.gameObject.GetComponentInParent<P2Controller>() != null)
        {
            GameManager.Instance.P1Wins++;
        }
    }


}
