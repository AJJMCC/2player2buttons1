﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBase : MonoBehaviour {

    public float MoveSpeed;

    public float startingFireCooldown;
    public float CooldownDecrease;
    public float MinColdown;

    private float RealNewTotalCooldown;
    private float RealCooldown;

    public GameObject bullet;
    public GameObject muzzleflash;
    public GameObject[] muzzles;

    // Use this for initialization
    void Start()
    {
        RealCooldown = startingFireCooldown;
        RealNewTotalCooldown = startingFireCooldown;


        if (this.transform.GetComponentInParent<P1Controller>() != null)
        {
            this.transform.GetComponentInParent<P1Controller>().ShipMoveSpeed = MoveSpeed;
        }
        if (this.transform.GetComponentInParent<P2Controller>() != null)
        {
            this.transform.GetComponentInParent<P2Controller>().ShipMoveSpeed = MoveSpeed;
        }
    }

    void Update()
    {
        Fire();
    }

    public void Fire()
    {
        if (GameManager.Instance.GamesStart)
        RealCooldown -= Time.deltaTime;

        if (RealCooldown <= 0)
        {
            foreach (GameObject t in muzzles)
            {
                Instantiate(bullet, t.transform.position, t.transform.rotation);
                if (muzzleflash != null)
                {
                    Instantiate(muzzleflash, t.transform.position, t.transform.rotation);

                }
            }

            if (RealNewTotalCooldown >= MinColdown)
            {
                RealNewTotalCooldown -= CooldownDecrease;
            }

            RealCooldown = RealNewTotalCooldown;
        }
    }
}
