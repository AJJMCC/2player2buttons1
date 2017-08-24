using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfly : MonoBehaviour {

    public float flyspeed;
    private float LifeTime;
    public GameObject Blast;

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
        Debug.Log("bullet hit");
        if (LifeTime >= 0.3f && other.gameObject.GetComponentInParent<P2Controller>() != null)
        {
            GameManager.Instance.P2Died();
            Instantiate(Blast, this.transform.position, Quaternion.identity);
        }
        else if (LifeTime >= 0.3f && other.gameObject.GetComponentInParent<P1Controller>() != null)
        {
            GameManager.Instance.P1Died();
            Instantiate(Blast, this.transform.position, Quaternion.identity);
        }
    }


}
