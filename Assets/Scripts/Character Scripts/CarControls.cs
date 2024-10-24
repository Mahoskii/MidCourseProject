using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControls : ICharacter
{
    public Animator animator;
    public Rigidbody2D rb;
    float boopForce = 2500f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        MovementAtUniqueSpeed(450000, rb, animator, "carSpeed");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            TrapInteraction(collision, rb, boopForce, "RedLightTrap", "BikeLaneTrap", "HighwayTrap");
    }

}
