using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeControls : ICharacter
{
    public Animator animator;
    public Rigidbody2D rb;
    float boopForce = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        MovementAtUniqueSpeed(2000, rb, animator, "bikeSpeed");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TrapInteraction(collision, rb, boopForce, "RedLightTrap", "HighwayTrap", "BikeLaneTrap");
    }

}
