using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControls : ICharacter
{
    public Rigidbody2D rb;
    float boopForce = 25f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        MovementAtUniqueSpeed(3000, rb);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            TrapInteraction(collision, rb, boopForce, "RedLightTrap", "BikeLaneTrap", "HighwayTrap");
    }

}
