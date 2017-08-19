using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSHip : MonoBehaviour {


    public float MoveSpeed;

    public float startingFireCooldown;
    public float CooldownDecrease;
    public float MinColdown;

    private float RealNewTotalCooldown;
    private float RealCooldown;

    public GameObject bullet;
    public GameObject muzzleflash;
    public GameObject muzzle;

    // Use this for initialization
    void Start () {
        RealCooldown = startingFireCooldown;
        RealNewTotalCooldown = startingFireCooldown;


       if ( this.transform.GetComponentInParent<P1Controller>() != null)
        {
            this.transform.GetComponentInParent<P1Controller>().ShipMoveSpeed = MoveSpeed;
        }
        if (this.transform.GetComponentInParent<P2Controller>() != null)
        {
            this.transform.GetComponentInParent<P2Controller>().ShipMoveSpeed = MoveSpeed;
        }
    }
	
	void Update ()
    {
        Fire();
	}

    public void Fire()
    {
        RealCooldown -= Time.deltaTime;

        if (RealCooldown <= 0)
        {
            Instantiate(bullet, muzzle.transform.position, muzzle.transform.rotation);
            Instantiate(muzzleflash, muzzle.transform.position, Quaternion.identity);
            if (RealNewTotalCooldown >= MinColdown)
            {
                RealNewTotalCooldown -= CooldownDecrease;
            }

            RealCooldown = RealNewTotalCooldown;
        }
    }
}
